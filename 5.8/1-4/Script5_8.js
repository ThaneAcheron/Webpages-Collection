function Clear(){ 
 document.getElementById('nameTxtb').value = "";
 document.getElementById('surNameTxtb').value = "";
 document.getElementById('radionBtnOne').checked = false;
 document.getElementById('radionBtnTwo').checked = false;
 document.getElementById('radionBtnThree').checked = false;
}
function Submit(){

 var txtbx1 = document.getElementById('nameTxtb');
 var txtbx2 = document.getElementById('surNameTxtb');
 var radio1 = document.getElementById('radionBtnOne');
 var radio2 = document.getElementById('radionBtnTwo');
 var radio3 = document.getElementById('radionBtnThree');
 
 if(txtbx1.value == "")
 { 
	 txtbx1.setCustomValidity('Please enter your name.');
	 txtbx1.style.background = "yellow";
 }
 else{ 
 txtbx1.setCustomValidity('');
 }
  if(txtbx2.value == "")
 {
	 txtbx2.setCustomValidity('Please enter your surname.');
	 txtbx2.style.background = "yellow";
 }
 else{
	 txtbx2.setCustomValidity('');
 }
  if(radio1.checked == false && radio2.checked == false && radio3.checked == false){
	 radio1.setCustomValidity('Please select a radio button');
  }else { 
     radio1.setCustomValidity('');
  }
}
function sendit(){    
var valid = document.register.checkValidity();
if(valid){
	alert("Page Valid!");
    document.register.submit();
 }
}	
