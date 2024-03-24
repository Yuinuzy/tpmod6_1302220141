// See https://aka.ms/new-console-template for more information

using tpmod6_130220141.SayaTubeVideo;

namespace program;
class Progam
{

    public static void Main(String[] Args)
    {
        SayaTubeVideo video = new SayaTubeVideo("", 0);
        for (int i = 0; i < 220; i++)
        {
            video.incrementPlayCount(10000000);
            video.printVideoDetails();
        }
        Console.WriteLine("max play count :" + int.MaxValue);

    }
}
