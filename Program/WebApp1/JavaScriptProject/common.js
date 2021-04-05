function func1() {
    var domArr =
        document.getElementsByName("inp1");

    if (domArr.length == 0)
        return;

    var dom = domArr[0];

    var val = dom.value;
    alert(val);
}


function func2() {
    var domArr =
        document.getElementsByName("inp1");

    if (domArr.length == 0)
        return;

    var dom = domArr[0];
    var val = dom.value;


    var domArr1 =
        document.getElementsByTagName("div");

    var container = domArr1[0]

    var newDom =
        document.createElement("p");

    newDom.innerText = val;
    container.appendChild(newDom);
}


function func3() {
    var domArr =
        document.getElementsByName("inp1");

    if (domArr.length == 0)
        return;

    var dom = domArr[0];
    var val = dom.value;

    var container = document.getElementById("id1");

    if (!container)
        return;

    var newDom =
        document.createElement("p");

    newDom.innerHTML = val;
    container.appendChild(newDom);
}

//var arr1 = [
//    "Paragraph 1",
//    "Paragraph 2"
//];
//var arr2 = [
//    { UserName: "John", Age: 17, Sex: "Male" },
//    { UserName: "Mary", Age: 17, Sex: "Female" },
//    { UserName: "Johnny", Age: 17, Sex: "Male" }
//];

function init() {
    var id2Container = document.getElementById("id2");

    if (id2Container) {
        //for (var i = 0; i < arr1.length; i++) {
        //    id2Container.innerHTML = "<span>" + arr1[i] + "</span>";
        //}

        //id2Container.innerHTML = "<span>123</span></span>456</span>";

        for (var i = 0; i < arr2.length; i++) {
            id2Container.innerHTML +=
                "<p><span>" +
                arr2[i].UserName + "</span><span>" +
                arr2[i].Age + "</span><span>" +
                arr2[i].Sex +
                "</span></p>";
        }
    }
}
// 自我啟動
//init();

function inpKeyUp_KeyUp() {
    var inp = document.getElementById("inpKeyUp");

    if (!inp)
        return;

    var txt = inp.value;
    txt = txt.toUpperCase();
    inp.value = txt;
}