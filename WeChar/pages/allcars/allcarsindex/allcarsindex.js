// pages/allcars/allcarsindex/allcarsindex.js
Page({

  /**
   * 页面的初始数据
   */
  data: {
    title: '车型大全',
  },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function() {
    var than = this;
    wx.request({
      url: 'http://localhost:56603/api/Bran/Getcarbrands',
      method: 'get',
      success: function(res) {
        console.log(res.data)
        than.setData({
          carbrans: res.data
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

  },
  chioecar: function(e) {
    var cartype = e.currentTarget.dataset.cartype;
    wx.request({
      url: '',
    })
  },
  newenergy: function(e) {
    var cartype = e.currentTarget.dataset.cartype;
    wx.request({
      url: '',
    })
  },
  ershou: function(e) {
    var cartype = e.currentTarget.dataset.cartype;
    wx.request({
      url: '',
    })
  },
  tobrandforum: function(e) {
    var brandname = e.currentTarget.dataset.brandname;
  },
})