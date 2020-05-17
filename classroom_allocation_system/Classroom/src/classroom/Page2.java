package classroom;


import java.awt.Color;
import java.awt.Container;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;



public class Page2 extends JFrame {
    private Container c1;
    private Font f;
    private JButton Next,Next1;
	private JLabel line,nextline,nextline1;
    
    Page2()
    {
        newcomponent();
    }
    
    public void newcomponent(){
         c1 = this.getContentPane();
        c1.setLayout(null);
        c1.setBackground(Color.LIGHT_GRAY);
        
        f = new Font("Arial", Font.BOLD,18);
		
		line = new JLabel("Welcome to Class room Allotment System");
		line.setBounds(50,50,400,150);
                line.setFont(f);
		c1.add(line);
		
		nextline = new JLabel("Cleck Here if you ");
		nextline.setBounds(30,100,250,150);
		c1.add(nextline);
        
        Next = new JButton("Admin");
        Next.setBounds(150, 150, 100, 50);
        c1.add(Next);
        
        Next.addActionListener((ActionEvent e) -> {
           /* page3 frame2 = new page3();
            frame2.setVisible(true);
            frame2.setBounds(1200, 50,500, 200);
            frame2.setTitle("Page 3 ");*/
           
            LoginFrame frame = new LoginFrame();
       frame.setVisible(true);
       frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
       frame.setBounds(200, 50,500, 400);
       frame.setTitle("Login");
			
         });
        
        
        nextline1 = new JLabel("Cleck Here if you ");
		nextline1.setBounds(30,200,250,150);
		c1.add(nextline1);
                
         Next1 = new JButton("Techer");
        Next1.setBounds(150, 250, 100, 50);
        c1.add(Next1);
        
        Next1.addActionListener((ActionEvent e) -> {
            LoginFramet frame1 = new LoginFramet();
            frame1.setVisible(true);
            frame1.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
            frame1.setBounds(200, 50,500, 400);
            frame1.setTitle("Login");
         });
        
        
 
        }
    
    
       
    
 
    
   

      
       
    
    public static void main(String[] args) {
       Page2 frame1 = new Page2();
       frame1.setVisible(true);
       frame1.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
       frame1.setBounds(700, 50,500, 800);
       frame1.setTitle("Welcome Page");
       
    }
    
}