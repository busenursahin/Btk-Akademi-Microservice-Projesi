using BtkAkademi.Service.ShoppingCartAPI.Models.Dto;

namespace BtkAkademi.Service.ShoppingCartAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponDto> GetCoupon(string couponName);
    }
}
