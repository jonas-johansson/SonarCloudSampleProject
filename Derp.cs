class Derp
{
    void InitializeRemoteConfig()
    {
        while (true)
        {
            Action action = () =>
            {
                for (int i = 0; i < 10; i++)
                {
                    try
                    {
                        if (i == 5)
                        {
                            throw new FileNotFoundException();
                        }
                        else
                        {
                            for (int j = 0; j < 5000; j++)
                            {
                                if (j == 1337)
                                {
                                    throw new FileNotFoundException();
                                }
                            }
                        }
                    }
                    catch (FileNotFoundException e)
                    {
                    }
                    catch (Exception e)
                    {
                    }
                }
            };

            action();
        }
    }
}