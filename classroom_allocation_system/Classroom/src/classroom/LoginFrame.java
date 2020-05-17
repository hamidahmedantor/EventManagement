package classroom;




import java.awt.Color;
import java.awt.Container;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPasswordField;
import javax.swing.JTextField;

public final class LoginFrame extends JFrame{
    private Container c;
    private JLabel Username,Password;
    private JPasswordField Pf;
    private Font f;
    private JTextField tf1,tf2;
    private JButton b1;
    
    LoginFrame()
    {
        components();
    }
     
    public void components(){
        c = this.getContentPane();
        c.setLayout(null);
        c.setBackground(Color.PINK);
        
        f = new Font("Arial", Font.BOLD,18);
        
        Username = new JLabel("Username :");
        Username.setBounds(50, 20,150,50);
        Username.setFont(f);
        c.add(Username);
        
        Password = new JLabel("Password :");
        Password.setBounds(50, 70,150,50);
        Password.setFont(f);
        c.add(Password);
        
        tf1 = new JTextField();
        tf1.setBounds(160, 20,150, 50);
        tf1.setHorizontalAlignment(JTextField.CENTER);
        tf1.setFont(f);
        c.add(tf1);
        
         Pf = new JPasswordField();
        Pf.setBounds(160, 70,150, 50);
        Pf.setHorizontalAlignment(JTextField.CENTER);
        Pf.setEchoChar('*');
        Pf.setFont(f);
        c.add(Pf);
        
        b1 = new JButton("Login");
        b1.setBounds(150, 150, 100, 50);
        c.add(b1);
        
        Handler handler = new Handler();
        b1.addActionListener(handler);

        
        
    }
    
    class Handler implements ActionListener {

        @Override
        public void actionPerformed(ActionEvent e) {
              if (e.getSource() == b1) {
                database1 l=new database1();
                 l.database(); 
                 
                  LoginDb mydbObj=new LoginDb();
 
                String pwd=new String(Pf.getPassword());
               
                System.out.println("Username,Pwd:"+tf1.getText()+","+pwd);
 
                
                if(mydbObj.checkLogin(tf1.getText(), pwd))
                {
                  	page3 frame2 = new page3();
            frame2.setVisible(true);
            frame2.setBounds(1200, 50,500, 200);
            frame2.setTitle("Page 3 "); }
                else
                {
                 
                    JOptionPane.showMessageDialog(null, "Wrong Username Or Password","Failed!!",
                                        JOptionPane.ERROR_MESSAGE);
                }
                }
             
            
        }
        
    

    }
   

    public static void main(String[] args) {
       LoginFrame frame = new LoginFrame();
       frame.setVisible(true);
       frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
       frame.setBounds(200, 50,500, 400);
       frame.setTitle("Login");
       
       
    }
    
}