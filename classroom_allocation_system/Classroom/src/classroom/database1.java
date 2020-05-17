/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package classroom;


import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;





public class database1 {
    Statement stmt;
               ResultSet rs;
        Connection con;
   public database1(){
           
   try {
                Class.forName("com.mysql.jdbc.Driver");
                 con = DriverManager.getConnection("jdbc:mysql://localhost:3306","root","");
                 stmt = con.createStatement();
                 
                   String sql, name, clsrm, prd;
          //     sql = "DROP DATABASE ClsrmAltmntSQL";
          //     stmt.executeUpdate(sql);
               sql = "CREATE DATABASE ClsrmAltmntSQL";
                stmt.executeUpdate(sql);
               sql = "use ClsrmAltmntSQL";
                stmt.executeUpdate(sql);
                 
                 } 
   catch (Exception ae) 
        {
            System.out.println("error while connecting: "+ae);
        }   }
   
   
    public void database(){  
           try{   
               String sql, name, clsrm, prd;
              // sql = "DROP DATABASE ClsrmAltmntSQL";
               //stmt.executeUpdate(sql);
               //sql = "CREATE DATABASE ClsrmAltmntSQL";
                //stmt.executeUpdate(sql);
               //sql = "use ClsrmAltmntSQL";
                //stmt.executeUpdate(sql);
            

                sql = "CREATE TABLE Allocate" 
                       //  + "(ID VARCHAR(255), "
                        + "(ClassRoom VARCHAR(255), "
                        + "1stPeriod VARCHAR(255), "
                        + "2ndPeriod VARCHAR(255), "
                        + "3rdPeriod VARCHAR(255), "
                        + "4thPeriod VARCHAR(255), "
                        + "Day VARCHAR(255))"  ;                
                      //  + "PRIMARY KEY (ID))";
                stmt.executeUpdate(sql);

             /*   sql = "INSERT INTO Allocate "
                        + "VALUES ('ClassRoom', '1stPeriod', '2ndPeriod', '3rdPeriod', '4thPeriod', 'Day')";
                stmt.executeUpdate(sql); */
                sql = "INSERT INTO Allocate "
                        + "VALUES ('CR-001', NULL, NULL, NULL, NULL, 'sun') ";
                stmt.executeUpdate(sql);
                  sql = "INSERT INTO Allocate "
                        + "VALUES ('CR-001', NULL, NULL, NULL, NULL, 'mon') ";
                stmt.executeUpdate(sql);
                  sql = "INSERT INTO Allocate "
                        + "VALUES ('CR-001', NULL, NULL, NULL, NULL, 'tues') ";
                stmt.executeUpdate(sql);
                  sql = "INSERT INTO Allocate "
                        + "VALUES ('CR-002', NULL, NULL, NULL, NULL, 'sun') ";
                stmt.executeUpdate(sql);
                sql = "INSERT INTO Allocate "
                        + "VALUES ('CR-002', NULL, NULL, NULL, NULL, 'mon') ";
                stmt.executeUpdate(sql);
                sql = "INSERT INTO Allocate "
                        + "VALUES ('CR-002', NULL, NULL, NULL, NULL, 'tues') ";
                stmt.executeUpdate(sql);
               sql = "INSERT INTO Allocate "
                        + "VALUES ('CR-003', NULL, NULL, NULL, NULL, 'sun') ";
                stmt.executeUpdate(sql);
                sql = "INSERT INTO Allocate "
                        + "VALUES ('CR-003', NULL, NULL, NULL, NULL, 'mon') ";
                stmt.executeUpdate(sql);
                sql = "INSERT INTO Allocate "
                        + "VALUES ('CR-003', NULL, NULL, NULL, NULL, 'tues') ";
                stmt.executeUpdate(sql);
                sql = "INSERT INTO Allocate "
                        + "VALUES ('CL-001', NULL, NULL, NULL, NULL, 'sun') ";
                stmt.executeUpdate(sql);
                sql = "INSERT INTO Allocate "
                        + "VALUES ('CL-001', NULL, NULL, NULL, NULL, 'mon') ";
                stmt.executeUpdate(sql);
                sql = "INSERT INTO Allocate "
                        + "VALUES ('CL-001', NULL, NULL, NULL, NULL, 'tues') ";
                stmt.executeUpdate(sql);
                sql = "INSERT INTO Allocate "
                        + "VALUES ('CL-002', NULL, NULL, NULL, NULL, 'sun') ";
                stmt.executeUpdate(sql);
                sql = "INSERT INTO Allocate "
                        + "VALUES ('CL-002', NULL, NULL, NULL, NULL, 'mon') ";
                stmt.executeUpdate(sql);
                sql = "INSERT INTO Allocate "
                        + "VALUES ('CL-002', NULL, NULL, NULL, NULL, 'tues') ";
                stmt.executeUpdate(sql);
      
                
                sql = "CREATE TABLE class_info " 
                    + "(classrooms VARCHAR(255), "
                    + "capability VARCHAR(255), "
                    + "computer VARCHAR(255), "
                    + "airconditioning VARCHAR(255), "
                    + "soundsystem VARCHAR(255), "
                    + "projector VARCHAR(255))";
            stmt.executeUpdate(sql);
            sql = "INSERT INTO class_info "
                    + "VALUES ('classrooms', 'capability', 'computer', 'airconditioning', 'soundsystem', 'projector')";
            stmt.executeUpdate(sql);
            sql = "INSERT INTO class_info "
                    + "VALUES ('CR-001', '50', 'NONE', 'YES', 'YES', 'YES')";
            stmt.executeUpdate(sql);
            sql = "INSERT INTO class_info "
                    + "VALUES ('CR-002', '40', 'NONE', 'YES', 'YES', 'YES')";
            stmt.executeUpdate(sql);
            sql = "INSERT INTO class_info "
                    + "VALUES ('CR-003', '45', 'NONE', 'YES', 'YES', 'YES')";
            stmt.executeUpdate(sql);
            sql = "INSERT INTO class_info "
                    + "VALUES ('CLAB-1', '50', '50', 'NO', 'NO', 'YES')";
            stmt.executeUpdate(sql);
            sql = "INSERT INTO class_info "
                    + "VALUES ('CLAB-2', '50', '48', 'YES', 'YES', 'YES')";
            stmt.executeUpdate(sql);
       
            
            } catch (Exception ae) {
                System.out.println("errorrrrr while connecting: "+ae);
            }
 
   }
    
} 
