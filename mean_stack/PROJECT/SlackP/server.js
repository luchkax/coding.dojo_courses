var express = require("express");
var app = express();
var mongoose = require('mongoose');
var bodyParser = require('body-parser');
var path = require('path');
var session = require("express-session");
var bcrypt = require('bcrypt');

var cors = require('cors');
app.use(cors());


app.use(bodyParser.json());
app.use(express.static(path.join(__dirname + '/angular-slack/dist')));
app.use(session({ secret: 'secretssecretsarenofunloljktheyamazing' }));


require("./express-slack/config/mongoose.js");
var routeSetter = require("./express-slack/config/routes.js")
routeSetter(app)


app.listen(8000, () => {
  console.log(__dirname);
  console.log("Listening on port 8000");
});
