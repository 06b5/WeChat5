// pages/carforum/search/search.js
Page({

  /**
   * 页面的初始数据
   */
  data: {
    title: "汽车之家查询",
  },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {
    this.setData({
      serechTitle: options.postTitle
    })
    var that = this;
    wx.request({
      url: 'http://localhost:56603/api/AddrForumIndex/GetAddrForumListsByName',
      method: 'GET',
      data: { forumName:options.postTitle},
      success: function (data) {
        that.setData({
          addrpostlist: data.data
        })
      }
    });
    wx.request({
      url: 'http://localhost:56603/api/AddrForumIndex/GetReplyNum?addrForumId=' + options.id,
      method: 'GET',
      success: function (res) {
        console.log(res.data);
        that.setData({
          addransernum: res.data
        })
      }
    });
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

  }
})