namespace CoffeShopManagement.Forms.Others
{
    //Homepage üzerinde güncelleme yapmasını istediğimiz classlara ekleriz
    internal interface IRefreshablePage
    {
        void RefreshPageForDatabaseUpdate();
    }
}
