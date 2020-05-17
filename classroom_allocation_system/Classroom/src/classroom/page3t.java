
package classroom;

import java.awt.Color;
import java.awt.Container;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;


public final class page3t extends JFrame {
    private Container c2;
    private JLabel line1,line2,line3;
    private Font f;
    private JButton Nxt1,Nxt2,Nxt3;
   
    
    page3t()
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
		
	JButton Nxt1 = new JButton("Next");
        Nxt1.setBounds(320, 20, 100, 50);
        c2.add(Nxt1);
        
        Nxt1.addActionListener((ActionEvent e) -> {
          //  System.out.println("ziad");
            
            java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new ClassRoom().setVisible(true);
            }
        });
            
         });
        
        line2 = new JLabel("Delete the Class");
        line2.setBounds(50, 70,350,50);
        line2.setFont(f);
        c2.add(line2);
        
       JButton Nxt2 = new JButton("Next");
        Nxt2.setBounds(320, 70, 100, 50);
        c2.add(Nxt2);
        
       Nxt2.addActionListener((ActionEvent e) -> {
           page4t frame2 = new page4t();
            frame2.setVisible(true);
            frame2.setBounds(1200, 50,500, 320);
            frame2.setTitle("Page 4t ");
         });
       
       line3 = new JLabel("Show classroom information");
        line3.setBounds(50, 120,350,50);
        line3.setFont(f);
        c2.add(line3);
        
        JButton Nxt3 = new JButton("Next");
        Nxt3.setBounds(320, 120, 100, 50);
        c2.add(Nxt3);
        
       Nxt3.addActionListener((ActionEvent e) -> {
           //System.out.println("Ziad");
                java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new ClassRoomInfo().setVisible(true);
            }
        });
         });
        
        
    
    }
    
   
    
    
    public static void main(String[] args) {
       page3t frame2 = new page3t();
       frame2.setVisible(true);
       frame2.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
       frame2.setBounds(1200, 50,500, 250);
       frame2.setTitle("page 3");
       
    }
    
}

