// pages/Mine/Mine_indend/Mine_indend.js
Page({
  button(event) {
    wx.navigateTo({
      url: '/pages/Mine/Details/Details',
    })
  },

  onLoad: function () {
    var that = this;
    wx.request({
      url: 'http://localhost:56603/api/user/GetMyShoppingList',
      method: 'GET',
      success: function (res) {
        console.log(res.data)
        that.setData({
          myShoppingList: res.data
        })
      }
    })
  }
})