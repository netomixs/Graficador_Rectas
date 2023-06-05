using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rectas
{
    public partial class Form1 : Form
    {
        //Declaracion del bitmap que se usa como para dibujar 
        Bitmap bitmap;
        //Declaracion del componente que nos ayuda hacer los trazoa
        Graphics g;
        //Declaracion de las difernetes tipos de plumas de diferentes colores
        Pen p1 = new Pen(Color.Black);
        Pen p2 = new Pen(Color.FromArgb(173, 173, 173));
        Pen p3 = new Pen(Color.FromArgb(66, 66, 66));
        SolidBrush brocha = new SolidBrush(Color.Green);
        Punto inico=new Punto(-1000,-1000), fin=new Punto(-1000,-1000);
        // Variables globales que se usa par definir el taamño de lienzo y el pixel
        int pixelSize = 10;
        int w, h;
        int posX, postY;
        //Se usa para asignar los datos al DataBing
        private CurrencyManager currencyManager = null;
        //Lista que contiene los puntos a graficar
        List<Punto> puntos;
        public Form1()
        {   // se inizializan las varibles
            InitializeComponent();
            puntos = new List<Punto>();
            dataDatos.DataSource = puntos;

        currencyManager = (CurrencyManager)dataDatos.BindingContext[puntos];
    }
 
        private void Form1_Load(object sender, EventArgs e)
        {// Cuando carga el formulario se llama para dibujar el escenario
            actualizar();
        }
        //Dibuja cuadricula y lineas
        void actualizar()
        {
            dibujarXy();
            dibujarLinea();
        }
        // Dibuja el fondo y los ejex x y
        void dibujarXy()
        {
            bitmap = new Bitmap(w, h);
            g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            g.DrawLine(p1, w / 2, 0, w / 2, h);
            g.DrawLine(p1, 0, h / 2, w, h / 2);
            lienzo.Image = bitmap;
            dibujarCuadricula();
        }
        // Dibuja la cuadricula
        void dibujarCuadricula()
        {
            dibujarHorizontalLineas();
            dibujarVerticales();
        }
        //Dibuja las lineas veriticales
        void dibujarVerticales()
        {
            for (int i = (w / 2) + (pixelSize / 2); i < w; i = i + pixelSize)
            {// lienas inferiores a la mitad
                // Cada 5 lineas se dibuja una mas gruesa
                if (i % 5 == 0)
                {
                    g.DrawLine(p3, i, 0, i, h);
                }
                else
                {
                    g.DrawLine(p2, i, 0, i, h);
                }
            }
            // lienas superioes a la mitad
            for (int i = (w / 2) + (pixelSize / 2); i >= 0; i = i - pixelSize)
            {
                
                if (i % 5 == 0)
                {
                    g.DrawLine(p3, i, 0, i, h);
                }
                else
                {
                    g.DrawLine(p2, i, 0, i, h);
                }
            }
        }
        void dibujarHorizontalLineas()
        {// lienas inferiores a la mitad
                // Cada 5 lineas se dibuja una mas gruesa
            for (int j = (h / 2) + (pixelSize / 2); j <h; j = j+ pixelSize)
            {
                if (j % 5 == 0)
                {
                    g.DrawLine(p3, 0, j, w, j);
                }
                else
                {
                    g.DrawLine(p2, 0, j, w, j);
                }

            } // lienas superioes a la mitad
            for (int j = (h / 2) + (pixelSize / 2); j >= 0; j = j - pixelSize)
            {
                if (j % 5 == 0)
                {
                    g.DrawLine(p3, 0, j, w, j);
                }
                else
                {
                    g.DrawLine(p2, 0, j, w, j);
                }
                
            }
        }
        private void lienzo_SizeChanged(object sender, EventArgs e)
        {//Carga el tamano del lienzo si es que cambi
            definirSize();
            if (w % 5 != 0)
            {
                w = w - (w % 5);
            }
            if (h % 5 != 0)
            {
                h = h - (h % 5);
            }
            dibujarXy();
        }
        //Carga el tamano del lienzo
        void definirSize()
        {
            w = this.lienzo.Width;
            h = this.lienzo.Height;
          
        }

        // cuando se da al boton aumenta el tamaño del pixel
        private void zoomBtnIn_Click(object sender, EventArgs e)
        {
            pixelSize = pixelSize + 2;
            actualizar();
        }
        // cuando se da al boton desminuya el tamaño del pixel
        private void zoomBtnOut_Click(object sender, EventArgs e)
        {
            pixelSize = pixelSize - 2;
            if (pixelSize<=0){
                pixelSize = 2;
            }
            actualizar();

        }

        private void lienzo_Click_2(object sender, EventArgs e)
        {/*
            int postRealX = MousePosition.X - this.Location.X;
            int postRealY = MousePosition.Y - this.Location.Y-30;
            posX = ((postRealX - w/2)-(postRealX)%10) /10;
            postY = (((h/2) - postRealY)- (postRealY) % 10) / 10;

            Console.WriteLine("Y "+ (postY));
            Console.WriteLine("Y real " + (postRealY));
            Console.WriteLine("X " + (posX));

            Console.WriteLine("Xreal " + postRealY);
            ///Console.WriteLine("X " + posX);
            //Console.WriteLine("X real " + (MousePosition.X-this.Location.X));
            dibujarXy();
           */

        }

        //Pinta unpixel en las coordenas indicadas
        void pintarPixel(int x, int y,Color color)
        {
            int xCenter =( w / 2) - (pixelSize / 2);
            int yCenter = (h / 2) - (pixelSize / 2);
            brocha.Color= color;
            g.FillRectangle(brocha, (xCenter+(pixelSize*x)),(yCenter-(pixelSize*y)) , pixelSize,pixelSize);
        }
        //Valida que los campos de texto contengan texto
        bool validarCampo()
        {
            int i = 0;
            if (string.IsNullOrEmpty(this.txtBoxX1.Text))
            {
                i++;
            }
            if (string.IsNullOrEmpty(this.txtBoxX2.Text))
            {
                i++;
            }
            if (string.IsNullOrEmpty(this.txtBoxY1.Text))
            {
                i++;
            }
            if (string.IsNullOrEmpty(this.txtBoxY2.Text))
            {
                i++;
            }
            if (i==0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //Al preciones el bpton calcular
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int x1=0,y1=0,x2=0,y2=0;
           
            if (validarCampo())

            {
                try
                {
                    x1 = Int16.Parse(this.txtBoxX1.Text);
                    x2 = Int16.Parse(this.txtBoxX2.Text);
                    y1 = Int16.Parse(this.txtBoxY1.Text);
                    y2 = Int16.Parse(this.txtBoxY2.Text);
                }
                catch {
                    MessageBox.Show("Ingresa solo numeros");
                    x1 = 0;
                    x2 = 0;
                    y1 = 0;
                    y2 = 0;
                }
                // Se recura los datos
              
                double pendiente = (double)(y2 - y1) / (x2 - y1);
                this.labelPendiente.Text = pendiente+"";
                // en caso de enotarse rectas horizontales
                if (x1==x2)
                {
                    pintarHorizontal(x1, y1, x2, y2);
                    Console.WriteLine("VErical");
            
                }
                // en caso de enotarse rectas veritcles
                else if (y1==y2)
                {
                    pintarVertical(x1, y1, x2, y2);

                }
                else if (this.radioButton1.Checked)
                {//Algoritmo basico
                    lineaBasica(x1, y1, x2, y2);
                }
                else if(this.radioButton2.Checked)
                {//Algoritmo DDA
                    DDA2(x1, y1, x2, y2);
                }
                else if(this.radioButton3.Checked)
                {//El que sobra
                    B(x1, y1, x2, y2);
                }
               
            }
            inico = new Punto(x1, y1);
            fin = new Punto(x2, y2);
            // Se colocan los puntos en el Databinding
            this.dataDatos.DataSource = puntos;
            //Se actualiza el leinzo
            actualizar();
            //Se dibuja la recta
            dibujarLinea();
            //Se pintan los pixeles inico y final
            
            pintarPixel(x1, y1, Color.Red);
            pintarPixel(x2, y2, Color.Red);
        }
        // Dinuja la lines contenida en la lista Puntos
        void dibujarLinea()
        {
         

            for (int i = 0; i < puntos.Count; i++)
            {
                Console.WriteLine(puntos[i].xEnter + " " + puntos[i].Y);
                pintarPixel(puntos[i].getX(), puntos[i].getY(), Color.Aqua);
            }
            pintarPixel(inico.getX(), inico.getY(), Color.Red);
            pintarPixel(fin.getX(), fin.getY(), Color.Red);
            Console.WriteLine(inico.xEnter);
        }
        private void Form1_Resize(object sender, System.EventArgs e)
        {
            Control control = (Control)sender;

            // Ensure the Form remains square (Height = Width).
            if (control.Size.Height != control.Size.Width)
            {
                control.Size = new Size(control.Size.Width, control.Size.Width);
            }
    
        }
        //Algorinto basico lineal
        void lineaBasica(int x1, int y1, int x2, int y2)
        {
            double dx, dy, i = 0;
            double m, b, y, x;
            dy = y2 - y1;
            dx = x2 - x1;
            m = (double)dy / (double)dx;
            b = y1 - m * x1;
            puntos = new List<Punto>();
            if (Math.Abs(dx) > Math.Abs(dy))
            {
                if (x1<x2)
                {
                    for (x = x1; x <= x2; x++)
                    {
                        y = m * x + b;
                        puntos.Add(new Punto(x, y));
                    }
                }
                else if(x1 > x2)
                {
                    for (x = x2; x <= x1; x++)
                    {
                        y = m * x + b;
                        puntos.Add(new Punto(x, y));
                        i++;
                    }
                }
                else if   (y1 < y2)
                    {
                }     
            }
            else
            {
                if (y1<y2)
                {
                    for (y = y1; y <= y2; y++)
                    {
                        x = (y - b) / m;
                        puntos.Add(new Punto(x, y));
                    }
                }
                else if(y2 < y1)
                {
                    for (y = y2; y <= y1; y++)
                    {
                        x = (y - b) / m;
                        puntos.Add(new Punto(x, y));
                    }
                }
                else
                { }
                
            }  
                pintarPixel(x1, y1, Color.Red);
                pintarPixel(x2, y2, Color.Red);
            
        }
        //Algorinto DDA
        void DDA2(int x1, int y1, int x2, int y2)
        {
            puntos = new List<Punto>();
            double pasos;
            double dy = y2 - y1;
            double dx = x2- x1;
            double incx, incy;
            double y = y1;
            double x = x1;
            if (Math.Abs(dy) > Math.Abs(dx))
            {
                pasos = Math.Abs(dy);
            }
            else
            {
                pasos = Math.Abs(dx); ;
            }
            incx = dx / (double)pasos;
            incy = dy / (double)pasos;
           
            for (int i=0;i<pasos;i++)
            {
                puntos.Add(new Punto(x,y));
                x = x + incx;
                y = y + incy;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        void B(int x1, int y1, int x2, int y2)
        {
            puntos = new List<Punto>();
            int dy = y2 - y1;
            int dx = x2 - x1;
            int pasox=0, pasoy=0, E, P,NE, y=y1,x=x1;
            if (dy < 0)
            { dy = -dy;
              pasoy = -1; 
            }else{
                pasoy = 1;}
            if (dx<0){
                dx = -dx;
                pasox = -1;
            }else{
                pasox = 1;}
            if (dx>dy){
                P = (2 * dy) - dx;
                E = 2 * dy;
                NE = (2 * dy) - (2 * dx);
                for (int i = 0; i < dx; i++){
                    puntos.Add(new Punto(x, y));
                    x = x + 1;
                    if (P <= 0){
                        P = P + E;
                    }else{
                        P = P + NE;
                        y = y +pasoy;}}
            }else{
                P = (2 * dx) - dy;
                E = 2 * dx;
                NE = (2 * dx) - (2 * dy);
                for (int i = 0; i < dy; i++){
                    puntos.Add(new Punto(x, y));
                    y = y + pasoy;
                    if (P <= 0){
                        P = P + E;
                    }else{
                        P = P + NE;
                        x = x + pasox;}}
            }           
        }

  
        // Metodo que genera puntos para una recta Horizontal
        void pintarHorizontal(int x1, int y1, int x2, int y2)
        {
            int aux = 0;
            if (y1 < y2)
            {

            }
            else
            {
                aux = y1;
                y1 = y2;
                y2 = aux;
            }
         
            puntos = new List<Punto>();
            for (int i=y1; i<y2;i++)
            {
                puntos.Add(new Punto(x1,i));
            }
        }
        // Metodo que genera puntos para una recta vertical
        void pintarVertical(int x1, int y1, int x2, int y2)
        {
            int aux = 0;
            if (x1<x2)
            {

            }
            else
            {
                aux = x1;
                x1 = x2;
                x2 = aux;
            }
            Console.WriteLine("Se ejeucto");
            puntos = new List<Punto>();
            for (int i = x1; i < x2; i++)
            {

                puntos.Add(new Punto(i, y1));
            }
        }
    }
    
}
