namespace AppInfoTests;

[TestClass]
public class AppInfo_Should
{
    [TestMethod]
    public void Return_FolderInfos()
    {
        // Arrange
        var sut = new ApplicationInfo();

        // Act
        var folders = sut.GetFolders();

        // Assert
        Assert.IsNotNull(folders);
        Assert.IsTrue(folders.Any());
    }

    [TestMethod]
    public void Fire_Initialized_Event()
    {
        // Arrange
        bool isInitializedCalled = false;
        Action<bool> handler = b  => isInitializedCalled = true;
        var sut = new ApplicationInfo();
        sut.Initialized += handler;

        // Act
        sut.Initialize();

        // Assert
        Assert.AreEqual(true, isInitializedCalled, "ApplicationInfo did not raise the event");
    }

    [TestInitialize]
    public void Init()
    {

    }

    [TestCleanup]
    public void Cleanup()
    {

    }
}