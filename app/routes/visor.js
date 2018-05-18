const dbConexion = require('../../config/Conexion');
var fs = require('fs');
const bodyParser = require('body-parser');
module.exports = elektro =>{

	const Conexion = dbConexion();
	elektro.use(bodyParser.urlencoded({ extended : false }));
	
     var StyleCss = {
         style :fs.readFileSync('static/css/style.css','utf8'),
         bootstrapmin :fs.readFileSync('static/css/bootstrap.min.css','utf8'),
         normalize :fs.readFileSync('static/css/normalize.min.css','utf8'),
         bootstrapjs :fs.readFileSync('static/js/bootstrap.js'),
         bootstrapminjs :fs.readFileSync('static/js/bootstrap.min.js'),
         querymin :fs.readFileSync('static/js/jquery.min.js'),
         cargagif :fs.readFileSync('static/gifs/barra-de-ebonita.gif'),
         cargaled :fs.readFileSync('static/img/leds.png')
     };

	elektro.get('/', (solicitud, respuesta) => {
		Conexion.query("Select * from conceptos where capitulo='cap21'", (err, result) =>{
			respuesta.render('inicio/main', {
				consulta : result,
				MyCss : StyleCss
				
			});
		});
	});
	elektro.get('/sin_datos', (solicitud, respuesta) =>{
		respuesta.render('inicio/sin_datos');
	});
	elektro.get('/ley_de_gauss', (solicitud, respuesta) => {
		Conexion.query("Select * from conceptos where capitulo='cap22'", (err, result) =>{
		if (result.length > 0) {
  			if (result)
  				respuesta.render('inicio/ley_gauss', {
					consulta : result,
					MyCss : StyleCss
				});
  		}
			else{respuesta.redirect('/sin_datos');}			
		});
	});
	elektro.get('/capacitancia', (solicitud, respuesta) => {
		Conexion.query("Select * from conceptos where capitulo='cap24'", (err, result) =>{
		if (result.length > 0) {
  			if (result)
  				respuesta.render('inicio/capacitancia', {
					consulta : result,
					MyCss : StyleCss
				});
  		}
			else{respuesta.redirect('/sin_datos');}			
		});
	});
	elektro.get('/potencial', (solicitud, respuesta) => {
	Conexion.query("Select * from conceptos where capitulo='cap23'", (err, result) =>{
	if (result.length > 0) {
		if (result)
  			respuesta.render('inicio/potencial', {
				consulta : result,
				MyCss : StyleCss
			});
  		}
			else{respuesta.redirect('/sin_datos');}			
		});
	});
	elektro.get('/simulador', (solicitud, respuesta) => {
			respuesta.render('inicio/simulador',{
				MyCss : StyleCss
			});
		});
};