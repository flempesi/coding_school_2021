// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function CheckboxFunction() {
    var checkBox = document.getElementById("checkActive");
   
    if (checkBox.checked == true) {
        //Model.SelectedListItem.Active=true;

        console.log(checkBox.checked);
    } else {
       // Model.SelectedListItem.Active=false;
    }
 
}