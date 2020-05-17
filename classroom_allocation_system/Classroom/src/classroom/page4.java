
package classroom;

import java.awt.Color;
import java.awt.Container;
import java.awt.Font;
import java.awt.event.ActionEvent;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextArea;



public final class page4 extends JFrame {
    private Container c1;
    private Font f;
    private JButton Allocate;
	private JComboBox d,p;
	private final String[] days = {"sun","mon","tues"};
	private final String[] periods = {"1stPeriod","2ndPeriod","3rdPeriod","4thPeriod"};
	private JLabel line,classroom,day,period;
	private JTextArea cl;
    
    page4()
    {
        newcomponent();
    }
    
    public void newcomponent(){
         c1 = this.getContentPane();
        c1.setLayout(null);
        c1.setBackground(Color.LIGHT_GRAY);
        
        f = new Font("Arial", Font.BOLD,18);
		
		line = new JLabel("For Allocate the class");
		line.setBounds(30,20,250,50);
                line.setFont(f);
		c1.add(line);
		
		Allocate = new JButton("Allocate");
        Allocate.setBounds(300,200, 80, 50);
        c1.add(Allocate);
		
		classroom = new JLabel("Classroom");
		classroom.setBounds(40,80,100,50);
		c1.add(classroom);
		
		cl = new JTextArea();
		cl.setBounds(120,90,60,30);
		c1.add(cl);
        
		day = new JLabel("Day");
		day.setBounds(40,150,100,50);
		c1.add(day);
		
		d = new JComboBox(days);
		d.setBounds(100,160,100,30);
		d.setEditable(true);
		c1.add(d);
		
                 period = new JLabel("Period");
		period.setBounds(40,200,100,50);
		c1.add(period);
		
		p = new JComboBox(periods);
		p.setBounds(100,210,130,40);
		p.setEditable(true);
		c1.add(p);
	
                String Per;
      Allocate.addActionListener((ActionEvent e) -> {
          // System.out.println("ziad");
           JOptionPane.showMessageDialog(null, "ClassRoom Allocated","",
                                        JOptionPane.ERROR_MESSAGE);
          
           String per=p.getSelectedItem().toString() ;
           String day=d.getSelectedItem().toString();
           String cls=cl.getText();
           
           displayDB d=new displayDB();
           d.allocate(per,day,cls);
        //   System.out.println(cls);
           
         });
    
    }
    
   
    
    
    public static void main(String[] args) {
       page4 frame1 = new page4();
       
       frame1.setVisible(true);
       frame1.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
       frame1.setBounds(700, 50,500, 320);
       frame1.setTitle("Admin Allocation");
       
    }
    
}