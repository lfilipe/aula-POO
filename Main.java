class Imovel {
    protected double area;
    private String numeroPredial;

    public Imovel(double area, String numeroPredial) {
        this.area = area;
        this.numeroPredial = numeroPredial;
    }

    public void abrirPorta() {
        System.out.println("Rodar a chave e empurrar a porta");
    }
}

class Moradia extends Imovel {
    double areaJardim;

    public Moradia(double area, String numeroPredial, double areaJardim) {
        super(area, numeroPredial);
        this.areaJardim = areaJardim;
    }

    public void mostrarJardim() {
        System.out.println("O jardim da moradia tem " + areaJardim + " m²");
    }
}

class Apartamento extends Imovel {
    int andar;

    public Apartamento(double area, String numeroPredial, int andar) {
        super(area, numeroPredial);
        this.andar = andar;
    }

    public void mostrarAndar() {
        System.out.println("Apartamento no " + andar + "º andar");
    }
}

public class Main {
    public static void main(String[] args) {

        Moradia moradiaCampo = new Moradia(300, "CASA-456", 50);
        moradiaCampo.mostrarJardim();

        Apartamento apartamento1Porto = new Apartamento(80, "APTO-00123", 3);
         apartamento1Porto.mostrarAndar();

         /*
         $ javac Main.java
         javac é o compilador Java. Lê o ficheiro Main.java e, se não existirem erros, gera o ficheiro Main.class, que contém o bytecode Java

         $ java Main
         java executa o programa. Reparar que se escreve Main, sem a extensão .java ou .class.
        
         Tudo junto: 
         $ javac Main.java && java Main
         */
    }
}
