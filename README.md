# MarketingListManager
A Marketing List Manager plugin for the [XrmToolbox](http://www.xrmtoolbox.com/) by [Tanguy Touzard](https://github.com/MscrmTools).

##Functionality
This tool will retrieve all the Marketing Lists available on your target instance and let you manipulate the FetchXML query for the dynamics lists.
Additionally, as CRM does not provide the member count for dynamic Marketing Lists. This tool allows you to execute the query iterating over the pages to obtain the real count of member for the list. The query is executed with No Lock to prevent perfomance issues.

##Setup
Simply download the [latest release](https://github.com/MscrmTools/XrmToolBox/releases/latest) and copy the DLL library into your XrmToolbox folder.
