// pages/allcars/Specification/Specification.js
Page({

  /**
   * 页面的初始数据
   */
  data: {

  },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function(options) {
    var than = this;
    console.log(options.Id)
    wx: wx.request({
        url: 'http://localhost:56603/api/Bran/GetCarMessages?id=' + options.Id,
        data: '',
        header: {},
        method: 'GET',
        dataType: 'json',
        responseType: 'text',
        success: function(res) {
          console.log(res.data)
          than.setData({
            carmessage: res.data
          })
        },
        fail: function(res) {},
        complete: function(res) {},
      }),
      wx.request({
        url: 'http://localhost:56603/api/Bran/GetCarSeries?id=' + options.Id,
        method: 'get',
        success: function(res) {
          console.log(res.data)
          console.log(res.Id)
          than.setData({
            carseries: res.data
          })
        }
      })
  },

  /**
   * 生命周期函数--监听页面初次渲染完成
   */
  onReady: function() {

  },

  /**
   * 生命周期函数--监听页面显示
   */
  onShow: function() {

  },

  /**
   * 生命周期函数--监听页面隐藏
   */
  onHide: function() {

  },

  /**
   * 生命周期函数--监听页面卸载
   */
  onUnload: function() {

  },

  /**
   * 页面相关事件处理函数--监听用户下拉动作
   */
  onPullDownRefresh: function() {

  },

  /**
   * 页面上拉触底事件的处理函数
   */
  onReachBottom: function() {

  },

  /**
   * 用户点击右上角分享
   */
  onShareAppMessage: function() {

  }
})