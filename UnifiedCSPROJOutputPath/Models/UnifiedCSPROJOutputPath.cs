using LibraryBasic.Models;
using System;
using System.IO;
using System.Xml;

namespace UnifiedCSPROJOutputPath.Models
{
    static public class UnifiedCSPROJOutputPath
    {
        static public bool delCSPROJBak(
            string inSRC_Folder
        )
        {
            bool result = false;

            try
            {
                string[] search_Folder_Arr
                    = MicrosoftWin32Custom.getAllFiles(
                        inSRC_Folder
                        , "*.csproj.bak"
                    );

                foreach (
                    string search_Folder_temp in search_Folder_Arr
                )
                {
                    if (
                        File.Exists(
                            search_Folder_temp
                        ) == false
                    )
                    {
                        continue;
                    }

                    if (
                        MicrosoftWin32Custom.deleteFile(
                            search_Folder_temp
                        ) == false
                    )
                        goto fatal;
                }

                result = true;
            }
            catch (Exception exception)
            {
                ExceptionCollect.write(
                    exception
                );
            }

fatal:
            return result;
        }

        static public bool restoreBakToCSPROJ(
            string inSRC_Folder
        )
        {
            bool result = false;

            try
            {
                string[] search_Folder_Arr
                    = MicrosoftWin32Custom.getAllFiles(
                        inSRC_Folder
                        , "*.csproj.bak"
                    );

                foreach (
                    string temp in search_Folder_Arr
                )
                {
                    string search_Folder_temp_BAK
                        = temp;
                    string search_Folder_temp
                        = search_Folder_temp_BAK.Replace(".bak", "");

                    if (
                        File.Exists(
                            search_Folder_temp_BAK
                        ) == false
                    )
                    {
                        continue;
                    }

                    if (
                        File.Exists(
                            search_Folder_temp
                        ) == true
                    )
                    {
                        if (
                            MicrosoftWin32Custom.deleteFile(
                                search_Folder_temp
                            ) == false
                        )
                            goto fatal;
                    }

                    File.Copy(
                        search_Folder_temp_BAK
                        , search_Folder_temp
                    );
                }

                result = true;
            }
            catch (Exception exception)
            {
                ExceptionCollect.write(
                    exception
                );
            }

fatal:
            return result;
        }

        static public bool updateCSPROJOutputPath(
            string inDES_Folder
            , string inDES_Folder_OuputFolder_Name
            , string inSRC_Folder
        )
        {
            bool result = false;

            try
            {
                string[] search_Folder_Arr
                    = MicrosoftWin32Custom.getAllFiles(
                        inSRC_Folder
                        , "*.csproj"
                    );

                foreach (
                    string search_Folder_temp in search_Folder_Arr
                )
                {
                    Uri uri_DES
                        = new Uri(
                            inDES_Folder
                        );
                    Uri uri_Search
                        = new Uri(
                            search_Folder_temp
                        );
                    string search_Folder_temp_BAK
                        = search_Folder_temp + ".bak";
                    string refPath = uri_Search
                        .MakeRelativeUri(
                            uri_DES
                        ).ToString()
                        .Replace("/", @"\");
                    string outputPath
                        = refPath
                            + inDES_Folder_OuputFolder_Name;

                    bool isChangFg = false;

                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.Load(
                        search_Folder_temp
                    );
                    XmlNodeList xmlNodeList
                        = xmlDocument.GetElementsByTagName(
                            "OutputPath"
                        );

                    if (
                        File.Exists(
                            search_Folder_temp_BAK
                        ) == false
                    )
                    {
                        xmlDocument.Save(
                            search_Folder_temp_BAK
                        );
                    }
                    

                    foreach (XmlNode xmlNodeTemp in xmlNodeList)
                    {
                        if (xmlNodeTemp.InnerText == outputPath)
                            continue;

                        xmlNodeTemp.InnerText = outputPath;
                        isChangFg = true;
                    }

                    if (isChangFg == true)
                    {
                        if (
                            MicrosoftWin32Custom.deleteFile(
                                search_Folder_temp
                            ) == false
                        )
                        {
                            continue;
                        }

                        xmlDocument.Save(
                            search_Folder_temp
                        );
                    }
                }

                result = true;
            }
            catch (Exception exception)
            {
                ExceptionCollect.write(
                    exception
                );
            }
fatal:
            return result;
        }
    }
}
