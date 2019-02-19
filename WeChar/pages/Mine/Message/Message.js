// pages/Mine/Message/Message.js
Page({
  message(event) {
    wx.navigateTo({
      url: '/pages/Mine/Invitation/Invitation',
    })
  },

  onLoad: function () {
    var that = this;
    wx.request({
      url: 'http://localhost:56603/api/user/GetMyMessage',
      method: 'GET',
      success: function (res) {
        console.log(res.data)
        that.setData({
          myMessage: res.data
        })
      }
    })
  }
})