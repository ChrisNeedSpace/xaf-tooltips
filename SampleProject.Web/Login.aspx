<%@ Page Language="C#" AutoEventWireup="true" Inherits="LoginPage" CodeBehind="Login.aspx.cs" %>
<%@ Register Assembly="DevExpress.ExpressApp.Web.v12.1" Namespace="DevExpress.ExpressApp.Web.Templates.ActionContainers"
    TagPrefix="cc2" %>
<%@ Register Assembly="DevExpress.ExpressApp.Web.v12.1" Namespace="DevExpress.ExpressApp.Web.Templates.Controls"
    TagPrefix="tc" %>
<%@ Register Assembly="DevExpress.ExpressApp.Web.v12.1" Namespace="DevExpress.ExpressApp.Web.Controls"
    TagPrefix="cc4" %>
<%@ Register Assembly="DevExpress.ExpressApp.Web.v12.1" Namespace="DevExpress.ExpressApp.Web.Templates"
    TagPrefix="cc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Logon</title>
	<link href="style.css" type="text/css" rel="stylesheet" />
</head>
<body class="Dialog">
    <div id="PageContent" class="PageContent DialogPageContent">
        <script src="scripts/MoveFooter.js" type="text/javascript"></script>
        <form id="form1" runat="server">
        <cc4:ASPxProgressControl ID="ProgressControl" runat="server" />
        <cc3:XafUpdatePanel ID="UPPopupWindowControl" runat="server">
            <cc4:XafPopupWindowControl runat="server" ID="PopupWindowControl" />
        </cc3:XafUpdatePanel>
        <cc3:XafUpdatePanel ID="UPVH" runat="server">
            <div class="Header">
                <table cellpadding="0" cellspacing="0" border="0">
                    <tr>
                        <td class="ViewImage">
                            <cc4:ViewImageControl ID="viewImageControl" runat="server" />
                        </td>
                        <td class="ViewCaption">
                            <h1>
                                <cc4:ViewCaptionControl ID="viewCaptionControl" DetailViewCaptionMode="ViewCaption"
                                    runat="server" />
                            </h1>
                        </td>
                    </tr>
                </table>
            </div>
        </cc3:XafUpdatePanel>
        <table class="DialogContent Content LogonContent" border="0" cellpadding="0" cellspacing="0"
            width="100%">
            <tr>
                <td class="LogonContentCell" align="center">
                    <cc3:XafUpdatePanel ID="UPEI" runat="server">
                        <tc:ErrorInfoControl ID="ErrorInfo" Style="margin: 10px 0px 10px 0px" runat="server" />
                    </cc3:XafUpdatePanel>
                    <asp:Table ID="Table1" CssClass="Logon" runat="server" BorderWidth="0px" CellPadding="0"
                        CellSpacing="0">
                        <asp:TableRow ID="TableRow2" runat="server">
                            <asp:TableCell runat="server" ID="ViewSite">
                                <cc3:XafUpdatePanel ID="UPVSC" runat="server">
                                    <cc4:ViewSiteControl ID="viewSiteControl" runat="server" />
                                </cc3:XafUpdatePanel>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TableRow3" runat="server">
                            <asp:TableCell runat="server" ID="TableCell4" HorizontalAlign="Right" Style="padding: 20px 0px 20px 0px">
                                <cc3:XafUpdatePanel ID="UPPopupActions" runat="server">
                                    <cc2:ActionContainerHolder ID="PopupActions" runat="server" Categories="PopupActions"
                                        Style="margin-left: 10px; display: inline" Orientation="Horizontal" ContainerStyle="Buttons">
                                    <Menu Width="100%" ItemAutoWidth="False" HorizontalAlign="Right"/>
                                    </cc2:ActionContainerHolder>
                                </cc3:XafUpdatePanel>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </td>
            </tr>
        </table>
        </form>
        <div id="Spacer" class="Spacer">
        </div>
        <script type="text/javascript">
    <!--
            function OnLoad() {
                DXMoveFooter();
                DXattachEventToElement(document.getElementById('formTable'), "resize", DXWindowOnResize);
                DXattachEventToElement(window, "resize", DXWindowOnResize);
            }
    //-->	    
        </script>
    </div>
</body>
</html>
