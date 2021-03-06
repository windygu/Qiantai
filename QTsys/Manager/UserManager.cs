﻿using QTsys.Common;
using QTsys.DAO;
using QTsys.DataObjects;
using System.Collections.Generic;
using System.Data;
using System;

namespace QTsys.Manager
{
    class UserManager
    {
        private UserDAO userDao;
        private CustomerDAO customerDao;

        public UserManager()
        {
            this.userDao = new UserDAO();
            this.customerDao = new CustomerDAO();
        }

        public static UserManager getUserManager()
        {
            return new UserManager();
        }

        public User Login(User user)
        {
            try
            {
                User result = null;
                // md5 password
                user.Password = Utils.GetMD5String(user.Password);

                var rUser = this.userDao.GetUserByUserName(user.UserName);

                if (user.Password == rUser.Password)
                {
                    result = rUser;
                }
                //var rs = resultObj.Status == "failed"  ? false : true;

                // TODO SET COOKIE

                return result;    // resultObj.success;
            }
            catch (Exception ex) {  throw ex; }
        }

        public void UpdateConnection()
        {
            this.userDao = new UserDAO();
            this.customerDao = new CustomerDAO();
        }

        public DataTable GetAllUser()
        {
            return this.userDao.GetAllUser();
        }

        public DataTable SearchUserByCol(string col, string value)
        {
            return this.userDao.SearchUserByCol(col, value);
        }

        public bool AddNewUser(User user)
        {
            return this.userDao.AddNewUser(user);
        }

        public bool DelUser(string key)
        {
            return this.userDao.DelUser(key);
        }

        public bool UpdateUser(User user)
        {
            return this.userDao.AltUser(user);
        }

        public bool AltUserPwd(string IDname, string Pwd)
        {
            return this.userDao.AltUserPwd(IDname, Pwd);
        }

        //public bool ValidateUserName(string name)
        //{
        //    return !this.userDao.GetAllUserNames().Contains(name);
        //}

        public bool CheckUsernameUnique(string userName)
        {
            return this.userDao.CheckUsernameUnique(userName);
        }

        # region customer management

        public DataTable GetAllCustomers()
        {
            return this.customerDao.GetAllCustomers();
        }

        public List<Customer> GetAllCustomerList()
        {
            try
            {
                List<Customer> customers = new List<Customer>();
                var dt = this.customerDao.GetAllCustomers();

                var l = dt.Rows.Count;
                for (int i = 0; i < l; i++)
                {
                    var rs = dt.Rows[i];
                    Customer customer = new Customer();

                    customer.Id = rs["客户编号"].ToString();
                    customer.Name = rs["客户名称"].ToString();
                    customer.Address = rs["地址"].ToString();
                    customer.Phone = rs["联系电话"].ToString();
                    customer.Fax = rs["传真"].ToString();
                    customer.Email = rs["电子邮箱"].ToString();
                    customer.PaymentMode = rs["结算方式"].ToString();
                    customer.Serial = rs["流水号"].ToString();
                    customer.Remarks = rs["备注"].ToString();

                    customers.Add(customer);
                }

                return customers;
            }
            catch (Exception ex) {   throw ex; }
        }

        //public List<CustomerMember> GetAllCustomerMemberList()
        //{
        //    List<CustomerMember> customers = new List<CustomerMember>();
        //    var dt = this.customerDao.GetAllCustomers();
        //    var l = dt.Rows.Count;
        //    for (int i = 0; i < l; i++)
        //    {
        //        var rs = dt.Rows[i];
        //        CustomerMember customer = new CustomerMember();
        //        customer.Id = rs["编号"].ToString();
        //        customer.Name = rs["姓名"].ToString();
        //        customer.Type = rs["类型"].ToString();
        //        customer.Phone = rs["联系电话"].ToString();
        //        customer.Email = rs["电子邮箱"].ToString();
        //        customer.CustomerId = rs["所属客户编号"].ToString();
        //        customers.Add(customer);
        //    }

        //    return customers;
        //}



        // TODO consider paging
        public DataTable GetCustomerMembersByCustomer(string cId)
        {
            return this.customerDao.GetCustomerMembersByCustomer(cId);
        }

        public List<CustomerMember> GetCustomerMembersByCId(string cId)
        {
            try
            {
                List<CustomerMember> cMembers = new List<CustomerMember>();
                var dt = this.customerDao.GetCustomerMembersByCustomer(cId);
                var l = dt.Rows.Count;
                for (int i = 0; i < l; i++)
                {
                    var rs = dt.Rows[i];
                    CustomerMember member = new CustomerMember();
                    member.Id = rs["编号"].ToString();
                    member.Name = rs["姓名"].ToString();
                    member.Type = rs["类型"].ToString();
                    member.Phone = rs["联系电话"].ToString();
                    member.Email = rs["电子邮件"].ToString();
                    member.CustomerId = rs["所属客户编号"].ToString();
                    cMembers.Add(member);
                }

                return cMembers;
            }
            catch (Exception ex) {  throw ex; }
        }

        public DataTable SearchCustomerByCol(string col, string name)//更新
        {
            return this.customerDao.SearchCustomerByCol(col, name);
        }

        public List<Customer> getDistinctRemarks()//更新
        {
            try
            {
                List<Customer> customers = new List<Customer>();
                var dt = this.customerDao.getDistinctRemarks();
                bool containsEmpty = false;

                var l = dt.Rows.Count;
                for (int i = 0; i < l; i++)
                {
                    var rs = dt.Rows[i];
                    Customer customer = new Customer();

                    //customer.Id = rs["客户编号"].ToString();
                    //customer.Name = rs["客户名称"].ToString();
                    //customer.Address = rs["地址"].ToString();
                    //customer.Phone = rs["联系电话"].ToString();
                    //customer.Fax = rs["传真"].ToString();
                    //customer.Email = rs["电子邮箱"].ToString();
                    //customer.PaymentMode = rs["结算方式"].ToString();
                    //customer.Serial = rs["流水号"].ToString();
                    customer.Remarks = rs["备注"].ToString().Trim();

                    if (customer.Remarks == "")
                    {
                        containsEmpty = true;
                    }

                    customers.Add(customer);
                }

                if (!containsEmpty)
                {
                    Customer customer = new Customer() { Remarks = "" };
                    customers.Add(customer);
                }

                return customers;
            }
            catch (Exception ex) { throw ex; }
        }

        public List<Customer> GetCustomersForChecking(DateTime from, DateTime end, string remarks)
        {
            try
            {
                List<Customer> customers = new List<Customer>();
                var dt = this.customerDao.GetCustomersForChecking(from, end, remarks);

                var l = dt.Rows.Count;
                for (int i = 0; i < l; i++)
                {
                    var rs = dt.Rows[i];
                    Customer customer = new Customer();

                    customer.Id = rs["客户编号"].ToString();
                    customer.Name = rs["客户名称"].ToString();
                    customer.Address = rs["地址"].ToString();
                    customer.Phone = rs["联系电话"].ToString();
                    customer.Fax = rs["传真"].ToString();
                    customer.Email = rs["电子邮箱"].ToString();
                    customer.PaymentMode = rs["结算方式"].ToString();
                    customer.Serial = rs["流水号"].ToString();
                    customer.Remarks = rs["备注"].ToString();

                    customers.Add(customer);
                }

                return customers;
            }
            catch (Exception ex) { throw ex; }
        }

        public DataTable SearchCustomerMemberByCol(string col, string name, string cId = "")//更新
        {
            return this.customerDao.SearchCustomerMemberByCol(col, name, cId);
        }

        public bool AddNewCustomer(Customer cus)
        {
            return this.customerDao.AddNewCustomer(cus);
        }

        public bool DelCustomer(string key)
        {
            return this.customerDao.DelCustomer(key);
        }

        public bool UpdateCustomer(Customer cus)
        {
            return this.customerDao.AltCustomer(cus);
        }


        public bool AddNewCustomerMember(CustomerMember cus)
        {
            return this.customerDao.AddNewCustomerMember(cus);
        }

        public bool DelCustomerMember(string key)
        {
            return this.customerDao.DelCustomerMember(key);
        }

        public bool UpdateCustomerMember(CustomerMember cus)
        {
            return this.customerDao.AltCustomerMember(cus);
        }

        # endregion
    }
}
