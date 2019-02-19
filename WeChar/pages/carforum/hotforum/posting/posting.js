// pages/carforum/hotforum/hotforuminfo/forumpost/posting/posting.js
Page({

  /**
   * 页面的初始数据
   */
  data: {

  },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {
    this.setData({
      hotid: options.hotid
    })
    console.log(hotid)
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
  posting: function (event) {
    var that = this;
    var hotid = event.currentTarget.dataset.hotid;
    var postTitle = event.detail.value.postTitle;
    var postContent = event.detail.value.postContent;
    wx.request({
      url: 'http://localhost:56603/api/HotForumIndex/Add',
      method: 'POST',
      data: {
        HotID: hotid,
        PostTitle: postTitle,
        PostContent: postContent,
        PostImgs: null
      },
      success: function (data) {
        wx.showToast({
          title: '发帖成功!'

        })
        that.onLoad();
      },
      fail: function (data) {
        console.log(data)
      }
    })
  },
})