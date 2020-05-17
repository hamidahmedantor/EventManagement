/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package classroom;

import java.awt.Color;
import java.awt.Container;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;


public final class page3 extends JFrame {
    private Container c2;
    private JLabel line1,line2;
    private Font f;
    private JButton Next1,Next2;
   
    
    page3()
    {
        newcomponent();
    }
    
    public void newcomponent(){
         c2 = this.getContentPane();
        c2.setLayout(null);
        c2.setBackground(Color.LIGHT_GRAY);
        
        f = new Font("Arial", Font.BOLD,18);
        
        line1 = new JLabel("Show available classroom");
        line1.setBounds(50, 20,350,50);
        line1.setFont(f);
        c2.add(line1);
		
       JButton Next1 = new JButton("Next");
        Next1.setBounds(280, 20, 100, 50);
        c2.add(Next1);
        
         Next1.addActionListener((ActionEvent e) -> {
           
           //System.out.println("ziad");
            
            java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new ClassRoom().setVisible(true);
            }
        });
            
         });
        
        line2 = new JLabel("Allocate a Classroom");
        line2.setBounds(50, 70,350,50);
        line2.setFont(f);
        c2.add(line2);
        
        JButton Next2 = new JButton("Next");
        Next2.setBounds(280, 70, 100, 50);
        c2.add(Next2);
        
       Next2.addActionListener((ActionEvent e) -> {
           page4 frame2 = new page4();
            frame2.setVisible(true);
            frame2.setBounds(1200, 50,500, 320);
            frame2.setTitle("Page 4t ");
         });
        
        
    
    }
    
   
    
    public static void main(String[] args) {
       page3 frame2 = new page3();
       frame2.setVisible(true);
       frame2.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
       frame2.setBounds(1200, 50,500, 200);
       frame2.setTitle("page 3");
       
    }
    
}