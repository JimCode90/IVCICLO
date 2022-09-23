
package ventanas;

import javax.swing.JOptionPane;

public class FrmPrincipal extends javax.swing.JFrame
{
    String dia[] = {"Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo"};

    public FrmPrincipal()
    {
        initComponents();
        setLocationRelativeTo(this);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabel1 = new javax.swing.JLabel();
        btnMostrar1 = new javax.swing.JButton();
        jScrollPane1 = new javax.swing.JScrollPane();
        txaResultado = new javax.swing.JTextArea();
        btnMostrar2 = new javax.swing.JButton();
        btnMostrar3 = new javax.swing.JButton();
        txtNro = new javax.swing.JTextField();
        btnMostrar4 = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Días de la semana");

        jLabel1.setText("Ingresa un nro");

        btnMostrar1.setText("if simple");
        btnMostrar1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnMostrar1ActionPerformed(evt);
            }
        });

        txaResultado.setColumns(20);
        txaResultado.setRows(5);
        jScrollPane1.setViewportView(txaResultado);

        btnMostrar2.setText("if anidado");
        btnMostrar2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnMostrar2ActionPerformed(evt);
            }
        });

        btnMostrar3.setText("switch-case");
        btnMostrar3.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnMostrar3ActionPerformed(evt);
            }
        });

        btnMostrar4.setText("Mejor opción");
        btnMostrar4.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnMostrar4ActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(23, 23, 23)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel1)
                        .addGap(18, 18, 18)
                        .addComponent(txtNro))
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(btnMostrar2, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(btnMostrar1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(btnMostrar4, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(btnMostrar3, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)))
                    .addComponent(jScrollPane1))
                .addContainerGap(28, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(21, 21, 21)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel1)
                    .addComponent(txtNro, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnMostrar1)
                    .addComponent(btnMostrar3))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnMostrar2)
                    .addComponent(btnMostrar4))
                .addGap(18, 18, 18)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(24, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnMostrar1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnMostrar1ActionPerformed
        // TODO add your handling code here:
        int n;
        n = Integer.parseInt(txtNro.getText());
        txaResultado.setText("");
        
        if(n == 1) txaResultado.append("Lunes");
        if(n == 2) txaResultado.append("Martes");
        if(n == 3) txaResultado.append("Miércoles");
        if(n == 4) txaResultado.append("Jueves");
        if(n == 5) txaResultado.append("Viernes");
        if(n == 6) txaResultado.append("Sábado");
        if(n == 7) txaResultado.append("Domingo");
    }//GEN-LAST:event_btnMostrar1ActionPerformed

    private void btnMostrar2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnMostrar2ActionPerformed
        // TODO add your handling code here:
        int n;
        n = Integer.parseInt(txtNro.getText());
        txaResultado.setText("");
        
        if(n == 1)
            txaResultado.append("Lunes");
        else
            if(n == 2)
                txaResultado.append("Martes");
            else
                if(n == 3)
                    txaResultado.append("Miércoles");
                else
                    if(n == 4)
                        txaResultado.append("Jueves");
                    else
                        if(n == 5)
                            txaResultado.append("Viernes");
                        else
                            if(n == 6)
                                txaResultado.append("Sábado");
                            else
                                if(n == 7)
                                    txaResultado.append("Domingo");
                                else
                                    JOptionPane.showMessageDialog(this, "Debe ingresar un nro entre 1 y 7");
    }//GEN-LAST:event_btnMostrar2ActionPerformed

    private void btnMostrar3ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnMostrar3ActionPerformed
        // TODO add your handling code here:
        int n;
        n = Integer.parseInt(txtNro.getText());
        txaResultado.setText("");
        
        switch(n)
        {
            case 1: txaResultado.append("Lunes");
                    break;
            case 2: txaResultado.append("Martes");
                    break;
            case 3: txaResultado.append("Miércoles");
                    break;
            case 4: txaResultado.append("Jueves");
                    break;
            case 5: txaResultado.append("Viernes");
                    break;
            case 6: txaResultado.append("Sábado");
                    break;
            case 7: txaResultado.append("Domingo");
                    break;
            default: JOptionPane.showMessageDialog(this, "Debe ingresar un nro entre 1 y 7");
        }
    }//GEN-LAST:event_btnMostrar3ActionPerformed

    private void btnMostrar4ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnMostrar4ActionPerformed
        // TODO add your handling code here:
        int n;
        n = Integer.parseInt(txtNro.getText());
        txaResultado.setText("");
        
        if(n<1 || n>7)
            JOptionPane.showMessageDialog(this, "Debe ingresar un nro entre 1 y 7");
        else
            txaResultado.append(dia[n-1]);
    }//GEN-LAST:event_btnMostrar4ActionPerformed

    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(FrmPrincipal.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(FrmPrincipal.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(FrmPrincipal.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(FrmPrincipal.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new FrmPrincipal().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnMostrar1;
    private javax.swing.JButton btnMostrar2;
    private javax.swing.JButton btnMostrar3;
    private javax.swing.JButton btnMostrar4;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTextArea txaResultado;
    private javax.swing.JTextField txtNro;
    // End of variables declaration//GEN-END:variables
}
