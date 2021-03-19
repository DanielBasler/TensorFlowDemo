using static Tensorflow.Binding;
using System.Text;

namespace TensorFlowDemo
{
    class Program
    {
        static void Main(string[] args)
        {            
            ASCIIEncoding ascii = new ASCIIEncoding();
            var hallo = tf.constant("Hallo, TensorFlow!");

            using (var sess = tf.Session())
            {
                var res = sess.run(hallo);                
                print(sess.run(hallo));

                string decoded = ascii.GetString(res.ToByteArray());                
                print(decoded);

            }            
        }
    }
}
