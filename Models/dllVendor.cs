﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace CitySeva.Models
{
    public class dllVendor
    {
        public DataTable GetVendorContactDetails(int vendorId)
        {
            SqlParameter[] pram = { new SqlParameter("@VendorId", vendorId) };
            return DataHealper.DbExecuteDataTable("usp_get_vendor_details_by_Id", pram);
        }


        public string UpdateVendorContactDetails(int vendorId, string fname,
            string lname, string email, string mobile, string address, string city, string pinCode, string state)
        {
            SqlParameter[] pram = {
             new SqlParameter("@VendorId", vendorId),
             new SqlParameter("@fname", fname),
             new SqlParameter("@lname", lname),
             new SqlParameter("@email", email),
             new SqlParameter("@mobile", mobile),
             new SqlParameter("@address", address),
             new SqlParameter("@city", city),
             new SqlParameter("@PinCode", pinCode),
             new SqlParameter("@State", state),
            };


            return DataHealper.DbExecuteExecuteScalar("usp_get_vendor_details_update", pram).ToString();
        }


        public DataTable GetVendorBusinessDetails(int vendorId)
        {
            SqlParameter[] pram = { new SqlParameter("@vendorId", vendorId) };
            return DataHealper.DbExecuteDataTable("UspVendorBusinessContactGet", pram);
        }

        public string UpdateVendorBusinessDetails(int vandor_Id, string business_name,
            string business_address, string category, string city, string other_city, string travel_and_stay, string business_running_from, string pinCode, string state)
        {
            SqlParameter[] pram = {
             new SqlParameter("@vandor_Id", vandor_Id),
             new SqlParameter("@business_name", business_name),
             new SqlParameter("@business_address", business_address),
             new SqlParameter("@category", category),
             new SqlParameter("@city", city),
             new SqlParameter("@other_city", other_city),
             new SqlParameter("@travel_and_stay", travel_and_stay),
             new SqlParameter("@business_running_from", business_running_from),
             new SqlParameter("@pinCode", pinCode),
             new SqlParameter("@state", state),
            };


            return DataHealper.DbExecuteExecuteScalar("UspVendorBusinessContactInsertUpdate", pram).ToString();
        }


        public DataTable GetIProductIems()
        {
            return DataHealper.DbExecuteDataTable("usp_items_get_list");

        }
        public DataTable GetIServicesIems()
        {
            return DataHealper.DbExecuteDataTable("usp_Service_get_list");

        }
    }
}