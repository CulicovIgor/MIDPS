<head>
<meta http-equiv="Content-Type" content="text/html; Charset=UTF-8">
<title>Pictures</title>
<script type="text/javascript" src="jquery.js"></script>
</head>
<?php
echo '<p style="text-align: center">Если нажать на кнопку, картинки изменяться!</p>';

?>
<style>
  .center { 
    text-align: center; 
  }
</style>
<div class = "center">
<button id="Change" onclick="loadLog();">Change</button>
</div>

<div class = "center" id="result"></div><br /><br />
<?php
echo '';
?>


<script type="text/javascript">
$( document ).ready(function() {
    loadLog();
});
function SendPost() {
	//отправляю POST запрос и получаю ответ
	$$a({
		type:'post',//тип запроса: get,post либо head
		url:'ajax.php',//url адрес файла обработчика
		data:{'z':'1'},//параметры запроса
		response:'json',//тип возвращаемого ответа text либо xml
		success:function (data) {//возвращаемый результат от сервера
			$$('result','<br />'+data);
		}
	});
}

function loadLog(){ 
$.ajax({ 
type: 'GET', 
url: 'ajax.php', 
data: { z: '1' }, 
dataType: 'json',
success: function (data) { 
var html='<br><br><table id="myTableId" border=`1` align="center">';
var igor = 0;
$.each(data, function(index, element) {
igor = igor+1;
if (igor % 2) {
html += '<tr>';
}
html += "<td><img src='"+element.link+"' style='width:500px;height:312px;'></td>";
if (igor % 2 == 0)
html += '</tr>';
});
html += '</table>';
$('#result').html(html);
}
});
}
</script>

