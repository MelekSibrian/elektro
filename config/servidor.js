//instalar dependencias con 
//npm i mysql express ejs body-parser
const directorio = require('path');
const express = require('express');
const bodyParser = require('body-parser');

const elektro = express();

//configuraciones
elektro.set('port', process.env.PORT || 3000);
elektro.set('view engine', 'ejs');
elektro.set('views', directorio.join(__dirname, '../app/views'));

elektro.use(bodyParser.urlencoded({extended: false}));
elektro.use(express.static(directorio.join(__dirname, '../static')));

module.exports = elektro;