import javax.swing.JOptionPane;
class palindrome{
	
	public static void main(String[] args){
		String texto1;
		String texto2= "";
		
		
		
		texto1=JOptionPane.showInputDialog("ingrese el texto");
		
		
	
		
		for(int i=texto1.length()-1  ;i>=0;i--){
			
			
			
			texto2=texto2+texto1.charAt(i);
			
			
		
			
		}
		
		if (texto1.equals(texto2)){
			
			System.out.println("true");
		}
		else
			System.out.println("false");
	}
}