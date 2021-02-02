/***********************************************************************************
 * 
 * Copyright:   Kellye Tolliver, tolliver.kellye@gmail.com
 * File Name:   DomainManager
 * Modified:    2020-01-20
 * Purpose:     Retrieve the user's current domain information.
 * 
 * *********************************************************************************/

using System;
using System.Text;
using System.DirectoryServices.ActiveDirectory;

namespace Harpocrates.ClassificationBanner
{
    public static class DomainManager
    {
        /// <summary>
        /// Retrieve and set the domain controller information for the user.
        /// </summary>
        static DomainManager()
        {
            Domain domain = null;
            DomainController domainController = null;
            try
            {
                domain = Domain.GetCurrentDomain();
                DomainName = domain.Name;
                domainController = domain.PdcRoleOwner;
                DomainControllerName = domainController.Name.Split('.')[0];
                ComputerName = Environment.MachineName;
            }
            finally
            {
                if (domain != null)
                    domain.Dispose();
                if (domainController != null)
                    domainController.Dispose();
            }
        }
        #region Domain Variables
        public static string DomainControllerName { get; private set; }
        public static string ComputerName { get; private set; }
        public static string DomainName { get; private set; }
        public static string DomainPath
        {
            get
            {
                bool bFirst = true;
                StringBuilder sbReturn = new StringBuilder(200);
                string[] strlstDc = DomainName.Split('.');
                foreach (string strDc in strlstDc)
                {
                    if (bFirst)
                    {
                        sbReturn.Append("DC=");
                        bFirst = false;
                    }
                    else
                        sbReturn.Append(",DC=");

                    sbReturn.Append(strDc);
                }
                return sbReturn.ToString();
            }
        }
        public static string RootPath
        {
            get
            {
                return string.Format("LDAP://{0}/{1}", DomainName, DomainPath);
            }
        }
        #endregion
    }
}
