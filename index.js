const elektro = require('./config/servidor');

require('./app/routes/visor')(elektro);

//Encender Servidor
elektro.listen(elektro.get('port'), () =>{
	console.log('Servidor iniciado en puerto', elektro.get('port'));
});