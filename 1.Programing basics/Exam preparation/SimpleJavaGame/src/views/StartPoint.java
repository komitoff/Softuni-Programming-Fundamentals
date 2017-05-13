package views;

import java.awt.EventQueue;

import javax.swing.JButton;

public class StartPoint {
    public static void main(String[] args) {
        
        EventQueue.invokeLater(new Runnable() {
            public void run() {
                Application ex = new Application();
                JButton btn = new JButton("btn");
                btn.setBounds(50,50,50,50);
                ex.add(btn);
                ex.setVisible(true);
            }
        });
    }
}
