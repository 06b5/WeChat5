// pages/carforum/carforum.js
Page({

  /**
   * 页面的初始数据
   */
  data: {
    car_title: "汽车论坛",
  },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {
    var that = this;
  //地区论坛
    wx.request({
      url: 'http://localhost:56603/api/AddrForumIndex/GetAddrForumList?addrId=1',
      method: 'GET',
      data: {},
      success: function (data) {
        that.setData({
          addrforumlist: data.data
        })
      }
    });
    wx.request({
      url: 'http://localhost:56603/api/AddrForumIndex/GetReplyNum?addrForumId=1',
      method: 'GET',
      success: function (res) {
        console.log(res.data);
        that.setData({
          addrforumReplyNum: res.data
        })
      }
    });
   //热门论坛
    wx.request({
      url: 'http://localhost:56603/api/HotForumIndex/GetHotForumList?hotId=1',
      method: 'GET',
      data: {},
      success: function (data) {
        that.setData({
          hotforumlist: data.data
        })
      }
    });
    wx.request({
      url: 'http://localhost:56603/api/HotForumIndex/GetReplyNum?hotForumId=1',
      method: 'GET',
      success: function (res) {
        console.log(res.data);
        that.setData({
          hotforumReplyNum: res.data
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

  },
  Xi(event) {
    wx.navigateTo({
      url: '/pages/carforum/brandforum/brandforumindex/brandforumindex',
    })
  },
  Addr(event) {
    wx.navigateTo({
      url: '/pages/carforum/addrforum/addrforumindex/addrforumindex',
    })
  },
  Theme(event) {
    wx.navigateTo({
      url: '/pages/carforum/themeforum/themeforumindex/themeforumindex',
    })
  },
  Hot(event) {
    wx.navigateTo({
      url: '/pages/carforum/hotforum/hotforumindex/hotforumindex',
    })
  },
  AddrSeeContent: function (e) {
    var posttitle = e.currentTarget.dataset.posttitle;
    var id = e.currentTarget.dataset.id;
    wx.navigateTo({
      url: '/pages/carforum/addrforum/forumpost/forumpost?posttitle=' + posttitle + '&id=' + id,
    })
  },
  HotSeeContent: function (e) {
    var posttitle = e.currentTarget.dataset.posttitle;
    var id = e.currentTarget.dataset.id;
    wx.navigateTo({
      url: '/pages/carforum/hotforum/forumpost/forumpost?posttitle=' + posttitle + '&id=' + id,
    })
  },
  searchTitle: function (event) {
    var that = this;
    var postTitle = event.detail.value.postTitle;
    wx.navigateTo({
      url: '/pages/carforum/search/search?postTitle=' + postTitle,
    })
  },
})