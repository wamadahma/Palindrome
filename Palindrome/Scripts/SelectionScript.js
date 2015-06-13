/* Used to select the text box after the CheckForPalindrome button is pressed 
    making it easier for the user to enter in a different string */

function selectText() {
    var TextBox = document.getElementById("InputBox");
    TextBox.focus();
    TextBox.select();
}