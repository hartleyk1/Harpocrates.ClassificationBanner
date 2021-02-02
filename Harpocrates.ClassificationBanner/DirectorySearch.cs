/***********************************************************************************
 * 
 * Copyright:   Kellye Tolliver, tolliver.kellye@gmail.com
 * File Name:   DirectorySearch
 * Modified:    2020-01-20
 * Purpose:     Search for information pertaining to the user or role of an existing
 *      LDAP via the user's name or group. Retrieves the current logged in user's
 *      information. If data within the LDAP is not discovered, always return null.
 * 
 * *********************************************************************************/

using System;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;

namespace Harpocrates.ClassificationBanner
{
    class DirectorySearch
    {
        /// <summary>
        /// Search for the user's literal name and group within their current domain.
        /// If one is not provided, return null. If a connection or search fails,
        /// dispose of variables and safely end the search.
        /// </summary>
        /// <param name="userName_">Obtain the current logged in user's username</param>
        /// <returns>Return the results of the active directory search back to the user</returns>
        public static DirectoryEntry SearchForUser(string userName_)
        {
            DirectoryEntry de = null;
            DirectorySearcher directorySearcher = null;
            Domain domain = null;
            try
            {
                if (String.IsNullOrEmpty(userName_))
                    return null;

                string userName = userName_.StartsWith("CN=") ? userName_.Replace("CN=", String.Empty) : userName_;

                de = new DirectoryEntry("LDAP://" + Domain.GetCurrentDomain().Name);
                directorySearcher = new DirectorySearcher(de);
                directorySearcher.Filter = string.Format("(&(objectClass=person)(objectCategory=user)(sAMAccountname={0}))", userName);
                SearchResult searchResult = directorySearcher.FindOne();

                return searchResult != null ? searchResult.GetDirectoryEntry() : null;
            }
            finally
            {
                if (de != null)
                    de.Dispose();
                if (directorySearcher != null)
                    directorySearcher.Dispose();
                if (domain != null)
                    domain.Dispose();
            }
        }
    }
}