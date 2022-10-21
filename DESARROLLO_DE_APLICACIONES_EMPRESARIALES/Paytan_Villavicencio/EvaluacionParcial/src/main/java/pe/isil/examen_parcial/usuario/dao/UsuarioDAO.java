/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.isil.examen_parcial.usuario.dao;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.Types;
import pe.isil.examen_parcial.usuario.dao.mysql.MysqlConnection;
import pe.isil.examen_parcial.usuario.model.Usuario;

public class UsuarioDAO {

    public int registerUsuario(Usuario usuario) throws Exception {
        MysqlConnection mysqConn = new MysqlConnection();
        Connection conn = mysqConn.getConnection();
        int rowsAffected = 0;

        CallableStatement callSpRegistrarUsuario = conn.prepareCall("{call registerUsuario(?, ?, ?, ?, ?, ?, ?)}");
        callSpRegistrarUsuario.setString(1, usuario.getCorreo());
        callSpRegistrarUsuario.setString(2, usuario.getNombre());
        callSpRegistrarUsuario.setString(3, usuario.getApePaterno());
        callSpRegistrarUsuario.setString(4, usuario.getApeMaterno());
        callSpRegistrarUsuario.setString(5, usuario.getDireccion());
        callSpRegistrarUsuario.setString(6, usuario.getPassword());
        callSpRegistrarUsuario.registerOutParameter(7, Types.INTEGER);
        callSpRegistrarUsuario.executeQuery();

        rowsAffected = callSpRegistrarUsuario.getInt(7);
        return rowsAffected;
    }

    public int loginUsuario(Usuario usuario) throws Exception {
        MysqlConnection mysqConn = new MysqlConnection();
        Connection conn = mysqConn.getConnection();
        int rowsAffected = 0;

        CallableStatement callSpLoginUsuario = conn.prepareCall("{call loginUsuario(?, ?, ?)}");
        callSpLoginUsuario.setString(1, usuario.getCorreo());
        callSpLoginUsuario.setString(2, usuario.getPassword());
        callSpLoginUsuario.registerOutParameter(3, Types.INTEGER);
        callSpLoginUsuario.executeQuery();

        rowsAffected = callSpLoginUsuario.getInt(3);
        return rowsAffected;
    }

    public String recoveryPasswordUsuario(Usuario usuario) throws Exception {
        MysqlConnection mysqConn = new MysqlConnection();
        Connection conn = mysqConn.getConnection();
        String recovery_passw_usu = "";

        CallableStatement callSpRecuperarPassword = conn.prepareCall("{call recoveryPassword(?, ?, ?)}");
        callSpRecuperarPassword.setString(1, usuario.getCorreo());
        callSpRecuperarPassword.registerOutParameter(2, Types.INTEGER);
        callSpRecuperarPassword.registerOutParameter(3, Types.VARCHAR);
        callSpRecuperarPassword.executeQuery();

        recovery_passw_usu = callSpRecuperarPassword.getString(3);
        System.out.println(recovery_passw_usu);

        return recovery_passw_usu;
    }
}
