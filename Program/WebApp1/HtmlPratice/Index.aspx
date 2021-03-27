﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="HtmlPratice.Index" %>


<%@ Register Src="~/ucFooter.ascx" TagPrefix="uc1" TagName="ucFooter" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Massively by HTML5 UP</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, user-scalable=no" />
    <link rel="stylesheet" href="assets/css/main.css" />
    <noscript><link rel="stylesheet" href="assets/css/noscript.css" /></noscript>
</head>
<body class="is-preload">
    <form id="form1" runat="server">

        <!-- Wrapper -->
        <div id="wrapper" class="fade-in">

            <!-- Intro -->
            <div id="intro">
                <h1>
                    <%--This is<br />
                    Massively--%>
                    <asp:Literal ID="ltPageTitle" runat="server"></asp:Literal>
                </h1>
                <p>
                    <%--A free, fully responsive HTML5 + CSS3 site template designed by <a href="https://twitter.com/ajlkn">@ajlkn</a> for <a href="https://html5up.net">HTML5 UP</a><br />
                    and released for free under the <a href="https://html5up.net/license">Creative Commons license</a>.--%>
                    <asp:Literal ID="ltPageDesc" runat="server"></asp:Literal>
                </p>
                <ul class="actions">
                    <li><a href="#header" class="button icon solid solo fa-arrow-down scrolly">Continue</a></li>
                </ul>
            </div>

            <!-- Header -->
            <header id="header">
                <a href="index.html" class="logo">Massively</a>
            </header>

            <!-- Nav -->
            <nav id="nav">
                <ul class="links">
                    <li class="active"><a href="index.html">This is Massively</a></li>
                    <li><a href="generic.html">Generic Page</a></li>
                    <li><a href="elements.html">Elements Reference</a></li>
                </ul>
                <ul class="icons">
                    <li><a href="#" class="icon brands fa-twitter"><span class="label">Twitter</span></a></li>
                    <li><a href="#" class="icon brands fa-facebook-f"><span class="label">Facebook</span></a></li>
                    <li><a href="#" class="icon brands fa-instagram"><span class="label">Instagram</span></a></li>
                    <li><a href="#" class="icon brands fa-github"><span class="label">GitHub</span></a></li>
                </ul>
            </nav>

            <!-- Main -->
            <div id="main">

                <!-- Featured Post -->
                <article class="post featured">
                    <header class="major">
                        <span class="date">April 25, 2017</span>
                        <h2><a href="#">And this is a<br />
                            massive headline</a></h2>
                        <p>
                            Aenean ornare velit lacus varius enim ullamcorper proin aliquam<br />
                            facilisis ante sed etiam magna interdum congue. Lorem ipsum dolor<br />
                            amet nullam sed etiam veroeros.
                        </p>
                    </header>
                    <a href="#" class="image main">
                        <img src="images/pic01.jpg" alt="" /></a>
                    <ul class="actions special">
                        <li><a href="#" class="button large">Full Story</a></li>
                    </ul>
                </article>

                <!-- Posts -->
                <section class="posts">
                    <article>
                        <header>
                            <span class="date">April 24, 2017</span>
                            <h2><a href="#">Sed magna<br />
                                ipsum faucibus</a></h2>
                        </header>
                        <a href="#" class="image fit">
                            <img src="images/pic02.jpg" alt="" /></a>
                        <p>Donec eget ex magna. Interdum et malesuada fames ac ante ipsum primis in faucibus. Pellentesque venenatis dolor imperdiet dolor mattis sagittis magna etiam.</p>
                        <ul class="actions special">
                            <li><a href="#" class="button">Full Story</a></li>
                        </ul>
                    </article>
                    <article>
                        <header>
                            <span class="date">April 22, 2017</span>
                            <h2><a href="#">Primis eget<br />
                                imperdiet lorem</a></h2>
                        </header>
                        <a href="#" class="image fit">
                            <img src="images/pic03.jpg" alt="" /></a>
                        <p>Donec eget ex magna. Interdum et malesuada fames ac ante ipsum primis in faucibus. Pellentesque venenatis dolor imperdiet dolor mattis sagittis magna etiam.</p>
                        <ul class="actions special">
                            <li><a href="#" class="button">Full Story</a></li>
                        </ul>
                    </article>
                    <article>
                        <header>
                            <span class="date">April 18, 2017</span>
                            <h2><a href="#">Ante mattis<br />
                                interdum dolor</a></h2>
                        </header>
                        <a href="#" class="image fit">
                            <img src="images/pic04.jpg" alt="" /></a>
                        <p>Donec eget ex magna. Interdum et malesuada fames ac ante ipsum primis in faucibus. Pellentesque venenatis dolor imperdiet dolor mattis sagittis magna etiam.</p>
                        <ul class="actions special">
                            <li><a href="#" class="button">Full Story</a></li>
                        </ul>
                    </article>
                    <article>
                        <header>
                            <span class="date">April 14, 2017</span>
                            <h2><a href="#">Tempus sed<br />
                                nulla imperdiet</a></h2>
                        </header>
                        <a href="#" class="image fit">
                            <img src="images/pic05.jpg" alt="" /></a>
                        <p>Donec eget ex magna. Interdum et malesuada fames ac ante ipsum primis in faucibus. Pellentesque venenatis dolor imperdiet dolor mattis sagittis magna etiam.</p>
                        <ul class="actions special">
                            <li><a href="#" class="button">Full Story</a></li>
                        </ul>
                    </article>
                    <article>
                        <header>
                            <span class="date">April 11, 2017</span>
                            <h2><a href="#">Odio magna<br />
                                sed consectetur</a></h2>
                        </header>
                        <a href="#" class="image fit">
                            <img src="images/pic06.jpg" alt="" /></a>
                        <p>Donec eget ex magna. Interdum et malesuada fames ac ante ipsum primis in faucibus. Pellentesque venenatis dolor imperdiet dolor mattis sagittis magna etiam.</p>
                        <ul class="actions special">
                            <li><a href="#" class="button">Full Story</a></li>
                        </ul>
                    </article>
                    <article>
                        <header>
                            <span class="date">April 7, 2017</span>
                            <h2><a href="#">Augue lorem<br />
                                primis vestibulum</a></h2>
                        </header>
                        <a href="#" class="image fit">
                            <img src="images/pic07.jpg" alt="" /></a>
                        <p>Donec eget ex magna. Interdum et malesuada fames ac ante ipsum primis in faucibus. Pellentesque venenatis dolor imperdiet dolor mattis sagittis magna etiam.</p>
                        <ul class="actions special">
                            <li><a href="#" class="button">Full Story</a></li>
                        </ul>
                    </article>
                </section>

                <!-- Footer -->
                <footer>
                    <div class="pagination">
                        <!--<a href="#" class="previous">Prev</a>-->
                        <a href="#" class="page active">1</a>
                        <a href="#" class="page">2</a>
                        <a href="#" class="page">3</a>
                        <span class="extra">&hellip;</span>
                        <a href="#" class="page">8</a>
                        <a href="#" class="page">9</a>
                        <a href="#" class="page">10</a>
                        <a href="#" class="next">Next</a>
                    </div>
                </footer>

            </div>
            
            <!-- Footer -->
            <footer id="footer">
                <uc1:ucFooter runat="server" id="ucFooter" />
            </footer>

            <!-- Copyright -->
            <div id="copyright">
                <ul>
                    <li>&copy; Untitled</li>
                    <li>Design: <a href="https://html5up.net">HTML5 UP</a></li>
                </ul>
            </div>
        </div>

        <!-- Scripts -->
        <script src="assets/js/jquery.min.js"></script>
        <script src="assets/js/jquery.scrollex.min.js"></script>
        <script src="assets/js/jquery.scrolly.min.js"></script>
        <script src="assets/js/browser.min.js"></script>
        <script src="assets/js/breakpoints.min.js"></script>
        <script src="assets/js/util.js"></script>
        <script src="assets/js/main.js"></script>

    </form>
</body>
</html>
