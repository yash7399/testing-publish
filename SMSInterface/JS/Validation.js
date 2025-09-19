function onlyAlphaNumberic(evt) {

    var charCode = evt.keyCode;
    
    if (evt.keyCode == 0)
        charCode = evt.which;   

    if ((charCode > 31 && charCode < 48) || (charCode > 57 && charCode < 65) || (charCode > 90 && charCode < 97) || (charCode > 122))
        return false;

    return true;
}

function onlyNumbers(evt) {

    var charCode = evt.keyCode;    
    if (evt.keyCode == 0)
        charCode = evt.which;
    if (charCode > 31 && (charCode < 48 || charCode > 57))
    { return false; }
    else {
        return true;
    }
}

function storeHiddenBox(name)
{
    document.getElementById(name).value = '';
}

function AllowAlphabet(e)
{
    var keynum;
    var keychar;
    var charcheck;
    if(window.event) // IE
       keynum = e.keyCode;
    else if(e.which) // Netscape/Firefox/Opera
       keynum = e.which;
    keychar = String.fromCharCode(keynum);
    charcheck = /[a-zA-Z]/;
    return charcheck.test(keychar);        
}
