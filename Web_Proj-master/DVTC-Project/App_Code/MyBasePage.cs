using System;
using System.Web.UI;

/// <summary>
/// Summary description for MyBasePage
/// </summary>
public class MyBasePage : Page
{
    public MyBasePage()
    {
        PreRender += Page_PreRender;
    }
    private void Page_PreRender(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Title))
        {
            Title = "DVT&C Scanner App";
        }
    }
}