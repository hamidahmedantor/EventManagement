/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package classroom;


import java.awt.BorderLayout;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;
import java.util.ArrayList;

public class MyMain {

   
    public static void main(String[] args)
    {
       database1 l=new database1();
       l.database();
    
       displayDB d=new displayDB();
       d.displayAllocate();
       d.displayInfo();
       
     //  d.allocate("1stPeriod","sun","CR-001");
     //  d.displayAllocate();
       
     //  d.unallocate("1stPeriod","sun","CR-001");
     //  d.displayAllocate();
       
      // table1 t=new table1();
      // t.ClssShow();
       
         java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new ClassRoom().setVisible(true);
            }
        });
        
           java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new ClassRoomInfo().setVisible(true);
            }
        });
      
       
}

      private javax.swing.JScrollPane jScrollPane1;
       private javax.swing.JTable jTable1;
    
}
