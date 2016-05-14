<?php
$servername = "localhost";
$username = "midpser";
$password = "12345";
$str1="";
$str2="";
$str3="";
$str4="";
$igor_arr = array();
$link = mysql_connect($servername, $username, $password);
if (!$link) {
    die('Could not connect: ' . mysql_error());
}
mysql_select_db('PictLink');
$sql1 = mysql_query("SELECT `id`, `link` FROM `Linker` WHERE id = '".rand(1,20)."'");
    while ($result1 = mysql_fetch_array($sql1)) {
        //echo $result1['id'].": ".$result1['link']."<br>";
$row['id'] = $result1['id'];
$row['link'] = $result1['link'];
array_push($igor_arr,$row);
}
$sql2 = mysql_query("SELECT `id`, `link` FROM `Linker` WHERE id = '".rand(1,20)."'");
    while ($result2 = mysql_fetch_array($sql2)) {
$row['id'] = $result2['id'];
$row['link'] = $result2['link'];
array_push($igor_arr,$row);
}
$sql3 = mysql_query("SELECT `id`, `link` FROM `Linker` WHERE id = '".rand(1,20)."'");
    while ($result3 = mysql_fetch_array($sql3)) {
$row['id'] = $result3['id'];
$row['link'] = $result3['link'];
array_push($igor_arr,$row);
}
$sql4 = mysql_query("SELECT `id`, `link` FROM `Linker` WHERE id = '".rand(1,20)."'");
    while ($result4 = mysql_fetch_array($sql4)) {
$row['id'] = $result4['id'];
$row['link'] = $result4['link'];
array_push($igor_arr,$row);
}
if(isset($_GET['z'])) {
	echo json_encode($igor_arr);
}
//rand()
?>

