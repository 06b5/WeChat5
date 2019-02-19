// pages/carforum/brandforum/brandforuminfo/forumpost/posting/posting.js
Page({

  /**
   * 页面的初始数据
   */
  data: {
   title:'发布新帖'
   
  },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {
    this.setData({
      addrid: options.addrid
    })
    console.log(addrid)
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
  posting:function(event){
    var that = this;
    var addrid = event.currentTarget.dataset.addrid;
    var postTitle = event.detail.value.postTitle;
    var postContent = event.detail.value.postContent;
    wx.request({
      url: 'http://localhost:56603/api/AddrForumIndex/Add',
      method: 'POST',
      data: {
        AddrID: addrid,
        PostTitle: postTitle,
        PostContent: postContent,
        PostImgs:null
      },
      success: function (data) {
        wx.showToast({
          title: '发帖成功!'

        })
        that.onLoad();  
      },
      fail:function(data){
        console.log(data)
      }
    })
  },
})