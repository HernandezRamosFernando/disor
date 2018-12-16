const express = require("express");
const app = express();
const path = require("path");

app.use(express.static(path.join(__dirname,"public")));


app.listen(3000,function(){
console.log("servidor corriendo");
});

app.get("/",function(request,response){

    response.sendFile(path.join(__dirname,"./public/index.html"));
});