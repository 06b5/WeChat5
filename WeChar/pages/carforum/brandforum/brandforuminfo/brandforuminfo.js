// pages/carforum/brandforum/brandforuminfo/brandforuminfo.js
Page({

  /**
   * 页面的初始数据
   */
  data: {
    
    contentTitle:'奥迪TT好不好开'
  },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {
    this.setData({
      title: options.brandname +"论坛",

    }) 
  },

  /**
   * 生命周期函数--监听页面初次渲染完成
   */
  onReady: function () {

  },

  /**
   * 生命周期函数--监听页面显示
   */
  onShow: function () {

  },

  /**
   * 生命周期函数--监听页面隐藏
   */
  onHide: function () {

  },

  /**
   * 生命周期函数--监听页面卸载
   */
  onUnload: function () {

  },

  /**
   * 页面相关事件处理函数--监听用户下拉动作
   */
  onPullDownRefresh: function () {

  },

  /**
   * 页面上拉触底事件的处理函数
   */
  onReachBottom: function () {

  },

  /**
   * 用户点击右上角分享
   */
  onShareAppMessage: function () {

  },
  into:function(e){
    var brandtitle = e.currentTarget.dataset.brandtitle;
    wx.navigateTo({
      url: '/pages/carforum/brandforum/forumpost/forumpost?brandtitle=' + brandtitle,
    })
  },
   fatie(event) {
    wx.navigateTo({
      url: '/pages/carforum/brandforum/posting/posting',
    })
  },
})