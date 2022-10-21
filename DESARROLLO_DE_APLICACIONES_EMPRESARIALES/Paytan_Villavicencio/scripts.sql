
-- PROCEDIMIENTO ALMACENADO PARA INICIAR SESION
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `loginUsuario`(IN p_correo varchar(100), IN p_password varchar(20),
 INOUT existe INT)
BEGIN 
	SET existe = 0;
	SELECT id INTO existe
		FROM USUARIOS 
        WHERE STRCMP(correo, p_correo) = 0
        AND STRCMP(password, p_password) = 0;
END;

DELIMITER;



-- PROCEDIMIENTO ALMACENADO PARA RECUPERAR CONTRASEÑA
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `recoveryPassword`(IN p_correo varchar(100), INOUT  resultado INT, INOUT  password_usu VARCHAR(20))
BEGIN 
	SELECT COUNT(*) INTO resultado FROM USUARIOS WHERE correo = p_correo;
    IF resultado > 0 THEN
		SET password_usu = (SELECT password FROM USUARIOS WHERE correo = p_correo);
	ELSE
		SET password_usu = '';
	END IF;
END;

DELIMITER;

-- PROCEDIMIENTO ALMACENADO PARA REGISTRAR NUEVOS USUARIOS
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `registerUsuario`(IN p_correo varchar(100), IN p_nombre varchar(40),
 IN p_apePaterno varchar(40), IN p_apeMaterno varchar(40), IN p_direccion varchar(100), IN p_password varchar(20), INOUT resultado int)
BEGIN
	declare existe int;
	SELECT COUNT(*) INTO existe FROM USUARIOS WHERE correo = p_correo;
    
    IF existe > 0 THEN
		SET resultado = 0;
	ELSE
		INSERT INTO USUARIOS (correo, nombre, apePaterno, apeMaterno, direccion, password)
		VALUES (p_correo, p_nombre, p_apePaterno, p_apeMaterno, p_direccion, p_password);
        SET resultado = 1;
	END IF;
END;

DELIMITER;