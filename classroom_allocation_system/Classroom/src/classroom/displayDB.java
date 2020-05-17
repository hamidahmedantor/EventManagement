/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package classroom;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.logging.Level;
import java.util.logging.Logger;


/*import javax.swing.*; 
import java.awt.*;
import java.awt.event.*;
import javax.swing.table.TableModel;*/

public class displayDB {
    Statement stmt;
        ResultSet rs;
        Connection con;
        
           String sql;
          
     //  TableShow table=new TableShow();    
    
    public displayDB(){
        
     
           
   try {
                Class.forName("com.mysql.jdbc.Driver");
                 con = DriverManager.getConnection("jdbc:mysql://localhost:3306/ClsrmAltmntSQL","root","");
                 stmt = con.createStatement();
                 } 
   catch (Exception ae) 
        {
            System.out.println("error while connecting: "+ae);
        }   }
   
    
    
    public void displayAllocate(){
        
      
           
           
    
        try {
            sql = "SELECT * FROM Allocate";
            rs = stmt.executeQuery(sql);
            
            
             while (rs.next()) {
          
        System.out.println(rs.getString(1)+" "+rs.getString(2)+" "+rs.getString(3)+" "+rs.getString(4)+" "+rs.getString(5)+" "+rs.getString(6));  
          
         /*   table.ShowAllocate(
			      
				  rs.getString("name"),
				  rs.getString("source"),
				  rs.getString("destination"),
				  rs.getString("type"),
				  rs.getString("departure"),
				  rs.getString("arrival")
				 
			); */
      
             }
            
            
        } catch (SQLException e) {
              System.out.println("error while validating: "+e);
        }
         
        
        //c.add(table);
       // c.setLayout(null);
       // c.setVisible(true);
       // c.setSize(800,600);   
    
    }
    
    
     public void displayInfo(){
    
        try {
            sql = "SELECT * FROM class_info";
            rs = stmt.executeQuery(sql);
            
            
             while (rs.next()) {
              System.out.println(rs.getString(1)+" "+rs.getString(2)+" "+rs.getString(3)+" "+rs.getString(4)+" "+rs.getString(5)+" "+rs.getString(6));    
            
              
             }
            
            
        } catch (SQLException e) {
              System.out.println("error while validating: "+e);
        }
      }
     
     
     public void allocate(String prd,String day,String clsrm){
   try{  
     rs = stmt.executeQuery("SELECT " + prd + " FROM Allocate WHERE ClassRoom = '" + clsrm + "' AND Day = '"+day+"' ");
     
      while (rs.next()) {
           String chk = rs.getString(1);
         if (chk==null){
             stmt.executeUpdate("UPDATE Allocate SET " + prd + "= 'Allocated' WHERE ClassRoom = '" + clsrm + "' AND Day = '"+day+"'  "); }
               
             System.out.println(clsrm + " for " + prd + " has been allocated.");
           }
   
   }catch (SQLException e) {
              System.out.println("error while validating: "+e);
        }
     
     
     }
     
     
          public void unallocate(String prd,String day,String clsrm){
   try{  
     rs = stmt.executeQuery("SELECT " + prd + " FROM Allocate WHERE ClassRoom = '" + clsrm + "' AND Day = '"+day+"' ");
     
      while (rs.next()) {
           String chk = rs.getString(1);
         if (chk.equals("Allocated")) {
             stmt.executeUpdate(" DELETE FROM Allocate WHERE ClassRoom = '" + clsrm + "' AND Day = '"+day+"' "); }
               
             System.out.println(clsrm + " for " + prd + " has been unallocated.");
           }
   
   }catch (SQLException e) {
              System.out.println("error while validating: "+e);
        }
     
     
     }

    
    
}