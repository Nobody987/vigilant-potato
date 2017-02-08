using XML_Configurator.DataModel;

namespace XML_Configurator.XMLBuilder
{
    class CommentBuilder
    {
        public static string comment = "TO BE ADDED";

        public static string ItemCommentBuilder(generator_object_id item)
        {
            string padded_comment_add_active = item.Object_name.PadRight(50) + item.Object_active;
            string padded_comment_add_active_add_load_type = padded_comment_add_active.PadRight(70) + item.Object_load_type;
            string padded_final = padded_comment_add_active_add_load_type.PadRight(80);
            return padded_final;
        }
        public static string ItemCommentBuilder(datasource item)
        {
            string padded_comment_add_active = item.Datasource_name.PadRight(50) + item.Datasource_database;
            string padded_final = padded_comment_add_active.PadRight(80);
            return padded_final;
        }
        public static string ItemCommentBuilder(transformator_object_id item)
        {
            string padded_comment_add_active = item.Transformation_name.PadRight(50) + item.Transformation_active;
            string padded_final = padded_comment_add_active.PadRight(80);
            return padded_final;
        }
        public static string ItemCommentBuilder(load_types item) //dodati active
        {
            string padded_comment_add_active = item.Load_type_name.PadRight(50);
            string padded_final = padded_comment_add_active.PadRight(80);
            return padded_final;
        }
    }
}
