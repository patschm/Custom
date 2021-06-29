using System;

namespace DeRadio
{
    class Program
    {
        static void Main(string[] args)
        {
            RadioStation r538 = new RadioStation();
            r538.subscribers += OntvangstMethodes.ViaEther;
            r538.subscribers += OntvangstMethodes.ViaKabel;
            r538.subscribers += OntvangstMethodes.ViaMail;
            r538.subscribers += OntvangstMethodes.ViaPostduif;
            r538.subscribers += OntvangstMethodes.ViaSMS;
            r538.subscribers += OntvangstMethodes.ViaKabel;
            r538.subscribers += OntvangstMethodes.ViaEther;
            r538.subscribers += OntvangstMethodes.ViaKabel;
            r538.subscribers += OntvangstMethodes.ViaMail;
            r538.subscribers += OntvangstMethodes.ViaPostduif;
            r538.subscribers += OntvangstMethodes.ViaSMS;
            r538.subscribers += OntvangstMethodes.ViaKabel;
            r538.subscribers += OntvangstMethodes.ViaEther;
            r538.subscribers += OntvangstMethodes.ViaKabel;
            r538.subscribers += OntvangstMethodes.ViaMail;
            r538.subscribers += OntvangstMethodes.ViaPostduif;
            r538.subscribers += OntvangstMethodes.ViaSMS;
            r538.subscribers += OntvangstMethodes.ViaKabel;

            r538.Broadcast();

        }
    }
}
