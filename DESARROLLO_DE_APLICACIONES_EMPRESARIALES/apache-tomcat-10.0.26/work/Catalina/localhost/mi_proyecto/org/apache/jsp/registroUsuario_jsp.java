/*
 * Generated by the Jasper component of Apache Tomcat
 * Version: Apache Tomcat/10.0.26
 * Generated at: 2022-10-13 23:08:59 UTC
 * Note: The last modified time of this file was set to
 *       the last modified time of the source file after
 *       generation to assist with modification tracking.
 */
package org.apache.jsp;

import jakarta.servlet.*;
import jakarta.servlet.http.*;
import jakarta.servlet.jsp.*;

public final class registroUsuario_jsp extends org.apache.jasper.runtime.HttpJspBase
    implements org.apache.jasper.runtime.JspSourceDependent,
                 org.apache.jasper.runtime.JspSourceImports {

  private static final jakarta.servlet.jsp.JspFactory _jspxFactory =
          jakarta.servlet.jsp.JspFactory.getDefaultFactory();

  private static java.util.Map<java.lang.String,java.lang.Long> _jspx_dependants;

  private static final java.util.Set<java.lang.String> _jspx_imports_packages;

  private static final java.util.Set<java.lang.String> _jspx_imports_classes;

  static {
    _jspx_imports_packages = new java.util.HashSet<>();
    _jspx_imports_packages.add("jakarta.servlet");
    _jspx_imports_packages.add("jakarta.servlet.http");
    _jspx_imports_packages.add("jakarta.servlet.jsp");
    _jspx_imports_classes = null;
  }

  private volatile jakarta.el.ExpressionFactory _el_expressionfactory;
  private volatile org.apache.tomcat.InstanceManager _jsp_instancemanager;

  public java.util.Map<java.lang.String,java.lang.Long> getDependants() {
    return _jspx_dependants;
  }

  public java.util.Set<java.lang.String> getPackageImports() {
    return _jspx_imports_packages;
  }

  public java.util.Set<java.lang.String> getClassImports() {
    return _jspx_imports_classes;
  }

  public jakarta.el.ExpressionFactory _jsp_getExpressionFactory() {
    if (_el_expressionfactory == null) {
      synchronized (this) {
        if (_el_expressionfactory == null) {
          _el_expressionfactory = _jspxFactory.getJspApplicationContext(getServletConfig().getServletContext()).getExpressionFactory();
        }
      }
    }
    return _el_expressionfactory;
  }

  public org.apache.tomcat.InstanceManager _jsp_getInstanceManager() {
    if (_jsp_instancemanager == null) {
      synchronized (this) {
        if (_jsp_instancemanager == null) {
          _jsp_instancemanager = org.apache.jasper.runtime.InstanceManagerFactory.getInstanceManager(getServletConfig());
        }
      }
    }
    return _jsp_instancemanager;
  }

  public void _jspInit() {
  }

  public void _jspDestroy() {
  }

  public void _jspService(final jakarta.servlet.http.HttpServletRequest request, final jakarta.servlet.http.HttpServletResponse response)
      throws java.io.IOException, jakarta.servlet.ServletException {

    if (!jakarta.servlet.DispatcherType.ERROR.equals(request.getDispatcherType())) {
      final java.lang.String _jspx_method = request.getMethod();
      if ("OPTIONS".equals(_jspx_method)) {
        response.setHeader("Allow","GET, HEAD, POST, OPTIONS");
        return;
      }
      if (!"GET".equals(_jspx_method) && !"POST".equals(_jspx_method) && !"HEAD".equals(_jspx_method)) {
        response.setHeader("Allow","GET, HEAD, POST, OPTIONS");
        response.sendError(HttpServletResponse.SC_METHOD_NOT_ALLOWED, "JSPs only permit GET, POST or HEAD. Jasper also permits OPTIONS");
        return;
      }
    }

    final jakarta.servlet.jsp.PageContext pageContext;
    jakarta.servlet.http.HttpSession session = null;
    final jakarta.servlet.ServletContext application;
    final jakarta.servlet.ServletConfig config;
    jakarta.servlet.jsp.JspWriter out = null;
    final java.lang.Object page = this;
    jakarta.servlet.jsp.JspWriter _jspx_out = null;
    jakarta.servlet.jsp.PageContext _jspx_page_context = null;


    try {
      response.setContentType("text/html;charset=UTF-8");
      pageContext = _jspxFactory.getPageContext(this, request, response,
      			null, true, 8192, true);
      _jspx_page_context = pageContext;
      application = pageContext.getServletContext();
      config = pageContext.getServletConfig();
      session = pageContext.getSession();
      out = pageContext.getOut();
      _jspx_out = out;

      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("<!DOCTYPE html>\n");
      out.write("<html>\n");
      out.write("    <head>\n");
      out.write("        <link rel=\"shortcut icon\" href=\"images/favicon.png\">\n");
      out.write("    <!-- CSS bootstrap-->\n");
      out.write("    <link rel=\"stylesheet\" href=\"css/bootstrap.min.css\" />\n");
      out.write("    <!--  Style -->\n");
      out.write("    <link rel=\"stylesheet\" href=\"css/style.css\" />\n");
      out.write("    <!--  Responsive -->\n");
      out.write("    <link rel=\"stylesheet\" href=\"css/responsive.css\" />\n");
      out.write("    </head>\n");
      out.write("    <body>\n");
      out.write("\n");
      out.write("    <!--=========== Loader =============-->\n");
      out.write("    <div id=\"gen-loading\">\n");
      out.write("        <div id=\"gen-loading-center\">\n");
      out.write("            <img src=\"images/logo-1.png\" alt=\"loading\">\n");
      out.write("        </div>\n");
      out.write("    </div>\n");
      out.write("    <!--=========== Loader =============-->\n");
      out.write("\n");
      out.write("    <!-- register -->\n");
      out.write("    <section class=\"position-relative pb-0\">\n");
      out.write("        <div class=\"gen-register-page-background\" style=\"background-image: url('images/background/asset-3.jpeg');\">\n");
      out.write("        </div>\n");
      out.write("        <div class=\"container\">\n");
      out.write("            <div class=\"row\">\n");
      out.write("                <div class=\"col-lg-12\">\n");
      out.write("                    <div class=\"text-center\">\n");
      out.write("                        <form action=\"");
      out.print( request.getContextPath());
      out.write("/UsuarioServlet\" id=\"pms_register-form\" class=\"pms-form\" method=\"post\">\n");
      out.write("                            <h4>Register</h4>\n");
      out.write("                            <input type=\"hidden\" id=\"pmstkn\" name=\"pmstkn\" value=\"59b502f483\"><input type=\"hidden\"\n");
      out.write("                                name=\"_wp_http_referer\" value=\"/register/\">\n");
      out.write("                            <ul class=\"pms-form-fields-wrapper pl-0\">\n");
      out.write("                                <li class=\"pms-field pms-user-login-field \">\n");
      out.write("                                    <label for=\"pms_user_login\">Username *</label>\n");
      out.write("                                    <input id=\"pms_user_login\" name=\"nombre_usu\" type=\"text\" value=\"\">\n");
      out.write("                                </li>\n");
      out.write("                                <li class=\"pms-field pms-user-email-field \">\n");
      out.write("                                    <label for=\"pms_user_email\">E-mail *</label>\n");
      out.write("                                    <input id=\"pms_user_email\" name=\"apellido_usu\" type=\"text\" value=\"\">\n");
      out.write("                                </li>\n");
      out.write("                                <li class=\"pms-field pms-first-name-field \">\n");
      out.write("                                    <label for=\"pms_first_name\">First Name</label>\n");
      out.write("                                    <input id=\"pms_first_name\" name=\"correo_usu\" type=\"text\" value=\"\">\n");
      out.write("                                </li>\n");
      out.write("                               \n");
      out.write("                                <li class=\"pms-field pms-pass1-field\">\n");
      out.write("                                    <label for=\"pms_pass1\">Password *</label>\n");
      out.write("                                    <input id=\"pms_pass1\" name=\"password\" type=\"password\">\n");
      out.write("                                </li>\n");
      out.write("                                <li class=\"pms-field pms-pass2-field\">\n");
      out.write("                                    <label for=\"pms_pass2\">Repeat Password *</label>\n");
      out.write("                                    <input id=\"pms_pass2\" name=\"pass2\" type=\"password\">\n");
      out.write("                                </li>\n");
      out.write("                                <li class=\"pms-field pms-field-subscriptions \">\n");
      out.write("                                    <div class=\"pms-subscription-plan\"><label><input type=\"radio\"\n");
      out.write("                                                name=\"subscription_plans\" data-price=\"199\" data-duration=\"1\"\n");
      out.write("                                                value=\"7330\" checked=\"checked\" data-default-selected=\"true\"><span\n");
      out.write("                                                class=\"pms-subscription-plan-name\">Premium</span><span\n");
      out.write("                                                class=\"pms-subscription-plan-price\"><span class=\"pms-divider\"> -\n");
      out.write("                                                </span><span class=\"pms-subscription-plan-price-value\">199</span><span\n");
      out.write("                                                    class=\"pms-subscription-plan-currency\">$</span><span\n");
      out.write("                                                    class=\"pms-divider\"> / </span>1 Month</span><span\n");
      out.write("                                                class=\"pms-subscription-plan-trial\"></span><span\n");
      out.write("                                                class=\"pms-subscription-plan-sign-up-fee\"></span></label></div>\n");
      out.write("                                    <div class=\"pms-subscription-plan\"><label><input type=\"radio\"\n");
      out.write("                                                name=\"subscription_plans\" data-price=\"99\" data-duration=\"1\" value=\"7329\"\n");
      out.write("                                                data-default-checked=\"false\"><span\n");
      out.write("                                                class=\"pms-subscription-plan-name\">Standard</span><span\n");
      out.write("                                                class=\"pms-subscription-plan-price\"><span class=\"pms-divider\"> -\n");
      out.write("                                                </span><span class=\"pms-subscription-plan-price-value\">99</span><span\n");
      out.write("                                                    class=\"pms-subscription-plan-currency\">$</span><span\n");
      out.write("                                                    class=\"pms-divider\"> / </span>1 Month</span><span\n");
      out.write("                                                class=\"pms-subscription-plan-trial\"></span><span\n");
      out.write("                                                class=\"pms-subscription-plan-sign-up-fee\"></span></label></div>\n");
      out.write("                                    <div class=\"pms-subscription-plan\"><label><input type=\"radio\"\n");
      out.write("                                                name=\"subscription_plans\" data-price=\"29\" data-duration=\"1\" value=\"7328\"\n");
      out.write("                                                data-default-checked=\"false\"><span\n");
      out.write("                                                class=\"pms-subscription-plan-name\">Basic</span><span\n");
      out.write("                                                class=\"pms-subscription-plan-price\"><span class=\"pms-divider\"> -\n");
      out.write("                                                </span><span class=\"pms-subscription-plan-price-value\">29</span><span\n");
      out.write("                                                    class=\"pms-subscription-plan-currency\">$</span><span\n");
      out.write("                                                    class=\"pms-divider\"> / </span>1 Month</span><span\n");
      out.write("                                                class=\"pms-subscription-plan-trial\"></span><span\n");
      out.write("                                                class=\"pms-subscription-plan-sign-up-fee\"></span></label></div>\n");
      out.write("                                    <div id=\"pms-paygates-wrapper\"><input type=\"hidden\" class=\"pms_pay_gate\"\n");
      out.write("                                            name=\"pay_gate\" value=\"paypal_standard\"></div>\n");
      out.write("                                </li>\n");
      out.write("                            </ul>\n");
      out.write("                            <span id=\"pms-submit-button-loading-placeholder-text\" class=\"d-none\">Processing. Please\n");
      out.write("                                wait...</span>\n");
      out.write("                            <input type=\"hidden\" value=\"insert\" name=\"accion\">\n");
      out.write("                            <input name=\"pms_register\" type=\"submit\" value=\"Register\">\n");
      out.write("                        </form>\n");
      out.write("                    </div>\n");
      out.write("                </div>\n");
      out.write("            </div>\n");
      out.write("        </div>\n");
      out.write("    </section>\n");
      out.write("    <!-- register -->\n");
      out.write("\n");
      out.write("    <!-- Back-to-Top start -->\n");
      out.write("    <div id=\"back-to-top\">\n");
      out.write("        <a class=\"top\" id=\"top\" href=\"#top\"> <i class=\"ion-ios-arrow-up\"></i> </a>\n");
      out.write("    </div>\n");
      out.write("    <!-- Back-to-Top end -->\n");
      out.write("\n");
      out.write("    <!-- js-min -->\n");
      out.write("    <script src=\"js/jquery-3.6.0.min.js\"></script>\n");
      out.write("    <script src=\"js/asyncloader.min.js\"></script>\n");
      out.write("    <!-- JS bootstrap -->\n");
      out.write("    <script src=\"js/bootstrap.min.js\"></script>\n");
      out.write("    <!-- owl-carousel -->\n");
      out.write("    <script src=\"js/owl.carousel.min.js\"></script>\n");
      out.write("    <!-- counter-js -->\n");
      out.write("    <script src=\"js/jquery.waypoints.min.js\"></script>\n");
      out.write("    <script src=\"js/jquery.counterup.min.js\"></script>\n");
      out.write("    <!-- popper-js -->\n");
      out.write("    <script src=\"js/popper.min.js\"></script>\n");
      out.write("    <script src=\"js/swiper-bundle.min.js\"></script>\n");
      out.write("    <!-- Iscotop -->\n");
      out.write("    <script src=\"js/isotope.pkgd.min.js\"></script>\n");
      out.write("\n");
      out.write("    <script src=\"js/jquery.magnific-popup.min.js\"></script>\n");
      out.write("\n");
      out.write("    <script src=\"js/slick.min.js\"></script>\n");
      out.write("\n");
      out.write("    <script src=\"js/streamlab-core.js\"></script>\n");
      out.write("\n");
      out.write("    <script src=\"js/script.js\"></script>\n");
      out.write("\n");
      out.write("\n");
      out.write("</body>\n");
      out.write("</html>\n");
    } catch (java.lang.Throwable t) {
      if (!(t instanceof jakarta.servlet.jsp.SkipPageException)){
        out = _jspx_out;
        if (out != null && out.getBufferSize() != 0)
          try {
            if (response.isCommitted()) {
              out.flush();
            } else {
              out.clearBuffer();
            }
          } catch (java.io.IOException e) {}
        if (_jspx_page_context != null) _jspx_page_context.handlePageException(t);
        else throw new ServletException(t);
      }
    } finally {
      _jspxFactory.releasePageContext(_jspx_page_context);
    }
  }
}
