namespace YangKai.BlogEngine.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovePageModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "Content", c => c.String());
            //ɾ��pagesǰ��content����post.
            Sql("update A set [Content]=pages.content from posts A left join pages on pages.post_postid=A.postid");
            //ɾ�����ܲ�����content������.
            Sql("delete posts where content is null");
            //���������쳣,��ע������. 'FK_dbo.Pages_dbo.Posts_Post_PostId' is not a constraint.Could not drop constraint. See previous errors.
            //DropForeignKey("dbo.Pages", "Post_PostId", "dbo.Posts");
            DropIndex("dbo.Pages", new[] {"Post_PostId"});
            DropTable("dbo.Pages");
        }

        public override void Down()
        {
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        PageId = c.Guid(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        Content = c.String(nullable: false),
                        OrderId = c.Int(nullable: false),
                        Post_PostId = c.Guid(),
                    })
                .PrimaryKey(t => t.PageId);
            
            DropColumn("dbo.Posts", "Content");
            CreateIndex("dbo.Pages", "Post_PostId");
            AddForeignKey("dbo.Pages", "Post_PostId", "dbo.Posts", "PostId");
        }
    }
}
