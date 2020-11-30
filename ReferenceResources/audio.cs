public currentBullets = 1;

private AudioSource gunAudio;
public AudioClip gunshot; //set this in ispector with audiofile
public AudioClip outofammo; //set this in ispector with audiofile

void Awake()
{
    gunAudio = GetComponent<AudioSource>();

}

void Update()
{
    if (currentBullets == 0)
    {
       gunAudio.clip = outofammo;
    }
    else 
    {
       gunAudio.clip = gunshot;     
    }
   gunAudio.Play();
}
