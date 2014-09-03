<?php
$pattern='/[\d]{2}[ ]*(-)[ ]*[\d]{2}[ ]*(-)[ ]*[\d]{1,4}[ ]+[\d]+(\:)[\d]+/';
$text="Debugging with WordPress-Mario Peshev-28-08-2014 18:00 WordPress is a free and open source blogging tool 
and a content management system (CMS) based on PHP and MySQL... 
First steps with Laravel-Ivan Vankov-31-08-2014 19:00 Laravel is a free, 
open source PHP web application framework, designed for the development of model�view�controller 
(MVC) web applications. According to...
JavaScript with .NET-Pavel Kolev-12-09-2014 17:00 JavaScript (JS) is a 
dynamic computer programming language. It is most commonly used as part of web browsers, 
whose implementations allow client-side scripts to interact with the user, control the browser, 
communicate asynchronously...SEO optimization, social networks, digital marketing-Ognyan 
Mladenov-05-07-2014 18:00 Search engine optimization (SEO) is the process of affecting the visibility of 
a website or a web page in a search engine's \"natural\" or un-paid (\"organic\") search results. In general, 
the earlier (or higher ranked on the search results page), and more frequently...
Basic Game Theory-Georgi Georgiev-16-06-2014 15:00 Game theory is a study of strategic decision making. 
Specifically, it is \"the study of mathematical models of conflict and cooperation between intelligent 
rational decision-makers";
$count=preg_match_all($pattern,$text,$result,PREG_OFFSET_CAPTURE);
var_dump($result[0]);
?>