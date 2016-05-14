<html>
<head>
<meta http-equiv="Content-Type" content="text/html; Charset=UTF-8">
<title>Test Page!</title>
</head>
<body>
<script>

document.body.style.backgroundColor='#0000ff';

</script>


<?php 
echo '<p style="text-align: center">Hello, User!</p>'; 
echo '<p style="text-align: center">This is test page, just press this button.</p>';
?>
<form action="index.php" method="get" style="text-align: center">
<style type="text/css">
ul li {list-style:none; display:inline; background-color:#99ccff; padding:2px}
</style>
<input type="submit" name="button" value="This button!" />
</form>  
<?php
if (isset($_GET['button'])) {
header ('Location: igor.php');  // перенаправление на нужную страницу
   exit();
  }
?>
<?php
$servername = "localhost";
$username = "midpser";
$password = "12345";

$link = mysql_connect($servername, $username, $password);
if (!$link) {
    die('Could not connect: ' . mysql_error());
}
?>
</body></html>
