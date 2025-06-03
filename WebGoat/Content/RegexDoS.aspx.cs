using System;
using System.Web;
using System.Web.UI;
using System.Text.RegularExpressions;

namespace OWASP.WebGoat.NET
{
    public partial class RegexDoS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Code from https://www.owasp.org/index.php/Regular_expression_Denial_of_Service_-_ReDoS
        /// </summary>
        protected void btnCreate_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string password = txtPassword.Text;

            // Escape user input and anchor pattern to mitigate ReDoS
            string safePattern = "^" + Regex.Escape(userName) + "$";
            Regex testPassword = new Regex(safePattern);
            Match match = testPassword.Match(password);
            if (match.Success)
            {
                lblError.Text = "Do not include name in password.";
            }
            else
            {
                lblError.Text = "Good password.";
            }
        }
    }
}

