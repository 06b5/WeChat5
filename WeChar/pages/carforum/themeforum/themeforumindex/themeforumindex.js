// pages/carforum/themeforum/themeforum.js
Page({

  /**
   * 页面的初始数据
   */
  data: {
    title: "主题论坛",
  },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {
    var that = this;

    wx.request({
      url: 'http://localhost:56603/api/ThemeForumIndex/ThemeLists',
      method: 'GET',
      success: function (data) {
        console.log(data.data)
        that.setData({
          theme: data.data
        })
      }
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
  tothemeforum: function (e) {
    var themename = e.currentTarget.dataset.themename;
    var id = e.currentTarget.dataset.id;
    console.log(themename);
    wx.navigateTo({
      url: '/pages/carforum/themeforum/themeforuminfo/themeforuminfo?themename=' + themename + '&id=' + id,
    })
  }
})