Algoritmo FOM
	Definir diasemana como cadena;
	Leer diasemana;
	Si diasemana="Lunes" Entonces
		Escribir "Lunes es el primer día de la semana";
	SiNo
		Si diasemana="Martes" Entonces
			Escribir "Martes es el segundo dia de la semana";
		SiNo
			Si diasemana="Miercoles" Entonces
				Escribir "Miercoles es el tercer dia de la semana";
			SiNo
				Si diasemana="Jueves" Entonces
					Escribir "Jueves es cuarto dia de la semana";
				SiNo
					Si diasemana="Viernes" Entonces
						Escribir "Viernes es el quinto dia de la semana";
					SiNo
						Si diasemana="Sabado" Entonces
							Escribir "Sabado es el sexto dia de la semana";
						SiNo
							Escribir "Domingo es el ultimo dia de la semana";
						Fin Si
					Fin Si
				Fin Si
			Fin Si
		Fin Si
	Fin Si
FinAlgoritmo
